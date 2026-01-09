using System.Collections.Immutable;
using System.CommandLine;
using System.Diagnostics;
using xBuild.Build.Hooks;
using xBuild.Logging;
using xBuild.Options;
using xBuild.Targets;

namespace xBuild.Build;

/// <summary>
///     Main build runner
/// </summary>
/// <param name="logger"></param>
/// <param name="buildContext"></param>
/// <param name="buildOptions"></param>
/// <param name="serviceProvider"></param>
/// <param name="buildOptions"></param>
/// <param name="buildTargetCollections"></param>
public class BuildRunner(
    IBuildLogger logger,
    BuildContext buildContext,
    BuildOptions buildOptions,
    IServiceProvider serviceProvider,
    IEnumerable<IOptionsProvider> buildOptionCollections,
    IEnumerable<ITargetProvider> buildTargetCollections,
    IEnumerable<IBuildInitializedHandler> buildInitializedHandlers,
    IEnumerable<IBuildCompletedHandler> buildCompletedHandlers,
    IEnumerable<ITargetStartedHandler> targetStartedHandlers,
    IEnumerable<ITargetCompletedHandler> targetCompletedHandlers
)
{
    public IServiceProvider Services { get; } = serviceProvider;
    
    public async Task ExecuteAsync(string[] args)
    {
        var allTargets = buildTargetCollections
            .SelectMany(r => r.Targets)
            .DistinctBy(t => t.Name)
            .ToImmutableDictionary(t => t.Name);

        var arguments = buildOptionCollections
            .SelectMany(c => c.Arguments)
            .ToArray();

        var options = buildOptionCollections
            .SelectMany(c => c.Options)
            .ToArray();

        await BuildRootCommand(allTargets, arguments, options).Parse(args).InvokeAsync();
    }

    private RootCommand BuildRootCommand(
        ImmutableDictionary<string, ITarget> allTargets,
        IBuildArgument[] arguments,
        IBuildOption[] options
    )
    {
        var targetsDescription = allTargets.Values
            .Where(t => !t.Unlisted)
            .StringJoin(t =>
            {
                var str = $"  {t.Name} : {t.Description}";
                var triggersTargets = t.Triggers
                    .Select(f => f())
                    .Where(t => allTargets.Values.Contains(t))
                    .Where(triggered => !triggered.Unlisted)
                    .Select(triggered => triggered.Name)
                    .ToArray();

                if (triggersTargets.Length != 0)
                {
                    str += $" -> [{triggersTargets.StringJoin(", ")}]";
                }

                str += Environment.NewLine;

                return str;
            });

        var rootDescription =
            $"""
             TACTICAL NUKE INCOMING - Announcer, 2009

             Targets:
             {targetsDescription}
             """;

        var rootCommand = new RootCommand(rootDescription);

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

            var includedTargets = allTargets
                .ExceptBy(buildOptions.Exclude.Value, p => p.Key)
                .ToDictionary();

            var targetGraph = new TargetGraph(includedTargets);
            buildContext.TargetGraph = targetGraph;

            if (targetGraph.ExecutionGraphCycles.Any())
            {
                logger.LogErrorFormat($"Cycles in execution graph detected. Adjust targets to ensure that cycles are eliminated:");

                foreach (var c in targetGraph.ExecutionGraphCycles)
                {
                    logger.LogInformationFormat($"  - {c.Source.Name} <--> {c.Target.Name}");
                }

                return;
            }

            var invokedTargets = buildOptions.Target.Value.ToArray();
            var triggeredTargets = targetGraph.CollectTriggeredTargets(invokedTargets);

            foreach (var target in triggeredTargets)
            {
                buildContext.Targets[target] = null;
            }

            foreach (var handler in buildInitializedHandlers)
            {
                await handler.OnBuildInitialized();
            }
            
            await RunTargetsAsync(
                targetGraph,
                triggeredTargets,
                buildOptions.Skip.Value.ToHashSet()
            );
        });

        return rootCommand;
    }

    private async Task RunTargetsAsync(
        TargetGraph targetGraph,
        IReadOnlyCollection<ITarget> triggeredTargets,
        HashSet<string> skippedTargets
    )
    {
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

                var after = targetGraph.ExecutionGraph.TryGetOutEdges(target, out var outEdges)
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
                await Task.WhenAll(executableTargets.Values
                    .Select(async t => await t.ExecuteParallelAsync())
                );

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
}