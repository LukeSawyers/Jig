using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using NeoSmart.AsyncLock;
using xBuild.Build.Hooks;
using xBuild.Logging;
using xBuild.Targets;

namespace xBuild.Build;

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
        var result = await ExecuteTargetAsync();
        buildContext.TargetResults[target] = result;
        
        foreach (var targetCompletedHandler in targetCompletedHandlers)
        {
            await targetCompletedHandler.OnTargetCompleted(target, result);
        }

        // Determine whether to continue with the build
        if (result.ResultType == TargetExecutionResultType.Failed && !target.ProceedAfterFailure)
        {
            buildContext.Status = BuildStatus.Failed;
        }
    }

    private async ValueTask<TargetExecutionResult> ExecuteTargetAsync()
    {
        // If skipped, return that result
        if (skip)
        {
            return new TargetExecutionResult(TargetExecutionResultType.Skipped, TimeSpan.Zero);
        }

        // If a previous target has failed, only run if configured to do so
        if (buildContext.Status == BuildStatus.Failed && !target.ExecuteAfterFailure)
        {
            return new TargetExecutionResult(TargetExecutionResultType.Aborted, TimeSpan.Zero);
        }
        
        // Initialise the target scope
        await using var scope = serviceProvider.CreateAsyncScope();
        var targetContext = scope.ServiceProvider.GetRequiredService<TargetContext>();
        targetContext.Target = target;
        var targetLogger = scope.ServiceProvider.GetRequiredService<ITargetLogger>();

        foreach (var targetStartedHandler in targetStartedHandlers)
        {
            await targetStartedHandler.OnTargetStarted(target);
        }
        
        targetContext.Stopwatch.Start();
        
        try
        {
            foreach (var execution in target.Executions)
            {
                await execution.ExecuteAsync(buildContext, scope.ServiceProvider, buildContext.StoppingToken);
            }
            
            return new TargetExecutionResult(TargetExecutionResultType.Succeeded, targetContext.Stopwatch.Elapsed);
        }
        catch (Exception e)
        {
            var exception = e is TargetInvocationException ? e.InnerException ?? e : e;

            if (target.ProceedAfterFailure)
            {
                targetLogger.LogWarningFormat(exception.Message);
            }
            else
            {
                targetLogger.LogErrorFormat(exception.Message);
            }

            return new TargetExecutionResult(TargetExecutionResultType.Failed, targetContext.Stopwatch.Elapsed);
        }
    }
}