using System.Collections.Immutable;
using System.CommandLine;
using System.Diagnostics;
using System.Reflection;
using Jig.Build.Extension;
using Jig.Options;
using Jig.Targets;
using Microsoft.Extensions.Logging;
using Jig.Lang;

namespace Jig.Build;

/// <summary>
///     Main build runner
/// </summary>
/// <param name="logger"></param>
/// <param name="buildContext"></param>
/// <param name="buildOptions"></param>
/// <param name="serviceProvider"></param>
/// <param name="buildOptions"></param>
/// <param name="buildTargetCollections"></param>
internal class BuildRunner(
    ILogger<BuildRunner> logger,
    BuildContext buildContext,
    BuildOptions buildOptions,
    IServiceProvider serviceProvider,
    IEnumerable<IOptionsProvider> buildOptionCollections,
    IEnumerable<ITargetProvider> buildTargetCollections,
    IEnumerable<IBuildInitializedHandler> buildInitializedHandlers,
    IEnumerable<IBuildCompletedHandler> buildCompletedHandlers,
    IEnumerable<ITargetStartedHandler> targetStartedHandlers,
    IEnumerable<ITargetCompletedHandler> targetCompletedHandlers
) : IBuildRunner
{
    private bool _disposed;

    public IServiceProvider Services { get; } = serviceProvider;

    public async ValueTask<int> ExecuteAsync(string[] args)
    {
        // Print version info
        var info = typeof(BuildRunner).Assembly
            .GetCustomAttribute<AssemblyFileVersionAttribute>()?
            .Version;

        logger.LogInformation("Jig version {Version}", info);
        
        var arguments = buildOptionCollections
            .SelectMany(c => c.Arguments)
            .ToArray();

        var options = buildOptionCollections
            .SelectMany(c => c.Options)
            .ToArray();
        
        // Build the root command
        var rootCommand = new RootCommand();

        foreach (var argument in arguments)
        {
            rootCommand.Arguments.Add(argument.Argument);
        }

        foreach (var option in options)
        {
            rootCommand.Options.Add(option.Option);
        }

        // Set up command action
        rootCommand.SetAction(async parseResult =>
        {
            // Set the value of options in targets classes
            foreach (var argument in arguments)
            {
                argument.Set(parseResult);
            }

            foreach (var option in options)
            {
                option.Set(parseResult);
            }
            
            // Collect Targets and options 
            var allTargets = buildTargetCollections
                .SelectMany(r => r.Targets)
                .DistinctBy(t => t.Name)
                .ToImmutableDictionary(t => t.Name);
        
            // Build main dependency graph and check for cycles
            var includedTargets = allTargets
                .ExceptBy(buildOptions.Exclude.Value, p => p.Key)
                .ToDictionary();

            var targetGraph = buildContext.TargetGraph = new TargetGraph(includedTargets, buildOptions.Target.Value.ToArray());

            if (targetGraph.AllTargetsExecutionGraphCycles.Any())
            {
                logger.LogError("Cycles in execution graph detected. Adjust targets to ensure that cycles are eliminated:");

                foreach (var c in targetGraph.AllTargetsExecutionGraphCycles)
                {
                    logger.LogInformation("  - {SourceName} <--> {TargetName}", c.Source.Name, c.Target.Name);
                }

                return;
            }
            
            // Build initialized
            foreach (var handler in buildInitializedHandlers)
            {
                await handler.OnBuildInitialized();
            }

            await RunAsync();
        });

        // Run
        await rootCommand
            .Parse(args)
            .InvokeAsync();

        return buildContext.Status == BuildStatus.Succeeded ? 0 : 1;
    }
    
    private async ValueTask RunAsync()
    {
        if (buildContext.BuildCancelled.IsCancellationRequested)
        {
            return;
        }
        
        var triggeredTargets = buildContext.TargetGraph.InvokedExecutionGraph.Vertices.ToArray();

        foreach (var target in triggeredTargets)
        {
            buildContext.TargetResults[target] = null;
        }

        var skippedTargets = buildOptions.Skip.Value.ToHashSet();

        var sw = Stopwatch.StartNew();

        var executableTargets = new Dictionary<ITarget, ExecutableTarget>();

        foreach (var triggeredTarget in triggeredTargets)
        {
            _ = GetOrAddExecutableTarget(triggeredTarget);

            continue;

            ExecutableTarget? GetOrAddExecutableTarget(ITarget target)
            {
                if (!triggeredTargets.Contains(target))
                {
                    return null;
                }

                if (executableTargets.TryGetValue(target, out var executableTarget))
                {
                    return executableTarget;
                }

                var after = buildContext.TargetGraph.AllTargetsExecutionGraph.TryGetOutEdges(target, out var outEdges)
                    ? outEdges
                        .Select(e => GetOrAddExecutableTarget(e.Target))
                        .WhereNotNull()
                        .ToArray()
                    : [];

                return executableTargets[target] = new ExecutableTarget(
                    buildContext,
                    serviceProvider,
                    targetStartedHandlers,
                    targetCompletedHandlers,
                    skippedTargets.Contains(target.Name),
                    target,
                    after
                );
            }
        }

        switch (buildOptions.BuildConcurrency.Value)
        {
            case BuildConcurrency.Sequential:
            {
                foreach (var target in executableTargets.Values)
                {
                    await target.ExecuteSequentiallyAsync();
                }

                break;
            }

            case BuildConcurrency.Parallel:
            {
                await Task.WhenAll(executableTargets.Values.Select(async t => await t.ExecuteParallelAsync()));
                break;
            }
            default:
                throw new ArgumentOutOfRangeException();
        }

        if (buildContext.Status != BuildStatus.Failed)
        {
            buildContext.Status = BuildStatus.Succeeded;
        }

        buildContext.ElapsedTime = sw.Elapsed;

        foreach (var buildCompletedHandler in buildCompletedHandlers)
        {
            await buildCompletedHandler.OnBuildCompleted();
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (!_disposed)
        {
            _disposed = true;
            if (serviceProvider is IAsyncDisposable disposable)
            {
                await disposable.DisposeAsync();
            }
        }
    }
}