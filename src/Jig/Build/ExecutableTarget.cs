using System.Diagnostics;
using System.Reflection;
using Jig.Build.Extension;
using Jig.Logger;
using Jig.Targets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NeoSmart.AsyncLock;
using Jig.Lang;

namespace Jig.Build;

public class ExecutableTarget(
    BuildContext buildContext,
    IServiceProvider serviceProvider,
    IEnumerable<ITargetStartedHandler> targetStartedHandlers,
    IEnumerable<ITargetCompletedHandler> targetCompletedHandlers,
    bool skip,
    ITarget target,
    IReadOnlyList<ExecutableTarget> after
)
{
    private readonly AsyncLock _lock = new();

    private Task? _executedTask;

    public async ValueTask ExecuteSequentiallyAsync()
    {
        using var _ = await _lock.LockAsync();
        var task = _executedTask ??= Task.Run(async () =>
        {
            // Ensure this target's dependencies are run first
            foreach (var t in after)
            {
                await t.ExecuteSequentiallyAsync();
            }

            await RunTargetInternalAsync();
        });

        await task;
    }

    public async ValueTask ExecuteParallelAsync()
    {
        using var _ = await _lock.LockAsync();

        var task = _executedTask ??= Task.Run(async () =>
        {
            // Ensure this target's dependencies are run first
            await Task.WhenAll(after.Select(async t => await t.ExecuteParallelAsync()));
            await RunTargetInternalAsync();
        });

        await task;
    }

    private async ValueTask RunTargetInternalAsync()
    {
        await using var scope = serviceProvider.CreateAsyncScope();
        var logger = scope.ServiceProvider
            .GetRequiredService<ILoggerFactory>()
            .CreateLogger(string.Empty);

        using var _ = logger.BeginScope(new Dictionary<string, object>()
        {
            {
                BuildStateIds.Target, target.Name
            }
        });

        logger.LogInformation("Target Starting");
        var result = await ExecuteTargetAsync(logger, serviceProvider);
        var logLevel = result.ResultType switch
        {
            TargetExecutionResultType.Inconclusive => LogLevel.Warning,
            TargetExecutionResultType.Succeeded => LogLevel.Information,
            TargetExecutionResultType.Skipped => LogLevel.Warning,
            TargetExecutionResultType.Aborted => LogLevel.Error,
            TargetExecutionResultType.Failed => LogLevel.Error,
            _ => LogLevel.Debug
        };

        logger.Log(logLevel, "Target {ResultType}", result.ResultType);

        buildContext.TargetResults[target] = result;

        foreach (var targetCompletedHandler in targetCompletedHandlers)
        {
            await targetCompletedHandler.OnTargetCompleted(target, result);
        }

        // Determine whether to continue with the build
        if (result.ResultType == TargetExecutionResultType.Failed)
        {
            buildContext.Status = BuildStatus.Failed;
        }
    }

    private async ValueTask<TargetExecutionResult> ExecuteTargetAsync(
        ILogger logger,
        IServiceProvider serviceProvider
    )
    {
        // If skipped, return that result
        if (skip)
        {
            return new TargetExecutionResult(TargetExecutionResultType.Skipped, TimeSpan.Zero);
        }

        // If a previous target has failed, only run if configured to do so
        var abortTarget = target.UpstreamFailureMode switch
        {
            // Abort if there are not any targets that have failed
            UpstreamFailureMode.Abort => buildContext.TargetResults
                .Select(p => p.Value?.Let(v => new
                {
                    DownstreamFailureMode = p.Key.DownstreamFailureMode,
                    ResultType = v.ResultType
                }))
                .WhereNotNull()
                .Any(o =>
                    o.DownstreamFailureMode == DownstreamFailureMode.AbortAll &&
                    o.ResultType != TargetExecutionResultType.Succeeded),
            // Continue regardless of prior results
            UpstreamFailureMode.Continue => false,
            _ => throw new ArgumentOutOfRangeException()
        };

        if (abortTarget)
        {
            return new TargetExecutionResult(TargetExecutionResultType.Aborted, TimeSpan.Zero);
        }

        // Initialise the target scope
        foreach (var targetStartedHandler in targetStartedHandlers)
        {
            await targetStartedHandler.OnTargetStarted(target);
        }

        var sw = Stopwatch.StartNew();

        try
        {
            foreach (var execution in target.Executions)
            {
                await execution.ExecuteAsync(logger, buildContext, serviceProvider, buildContext.BuildCancelled);
            }

            return new TargetExecutionResult(TargetExecutionResultType.Succeeded, sw.Elapsed);
        }
        catch (Exception e)
        {
            var exception = e is TargetInvocationException ? e.InnerException ?? e : e;
            logger.LogError(exception, exception.Message);
            return new TargetExecutionResult(TargetExecutionResultType.Failed, sw.Elapsed);
        }
    }
}