using Microsoft.Extensions.Logging;
using xBuild.Lang;
using xBuild.Options;

namespace xBuild.Build.Extension.Logging;

public class DryRunExtension(
    ILogger<DryRunExtension> logger,
    IBuildContext buildContext
) : IBuildInitializedHandler, IOptionsProvider
{
    BuildOption<bool> DryRun { get; } = new(
        false,
        description: "Print a descriptive list of tasks to be run instead of running them"
    );

    public async ValueTask OnBuildInitialized()
    {
        if (!DryRun)
        {
            return;
        }

        logger.LogInformation("Dry Run:");
        logger.LogInformation("");

        foreach (var target in buildContext.TargetGraph.InvokedTargetsInOrder)
        {
            logger.LogInformation("{TargetName}:", target.Name);

            if (!target.Executions.Any())
            {
                logger.LogInformation(" - Target has no executions");
            }
            else if (target.Executions.All(e => string.IsNullOrWhiteSpace(e.Description.Format)))
            {
                logger.LogInformation(" - Target has {Count} undescribed executions", target.Executions.Count);
            }
            else
            {
                foreach (var execution in target.Executions)
                {
                    logger.LogInformation($" - {execution.Description.Format}", execution.Description.GetArguments());
                }
            }

            logger.LogInformation("");
        }

        // Cancel the build
        buildContext.Cancel();
    }
}

public class ListExtension(
    ILogger<ListExtension> logger,
    IBuildContext buildContext
) : IBuildInitializedHandler, IOptionsProvider
{
    public BuildOption<bool> List { get; } = new(false, description: "List available targets");

    /// <inheritdoc />
    public async ValueTask OnBuildInitialized()
    {
        if (!List)
        {
            return;
        }

        var targetGraph = buildContext.TargetGraph;

        foreach (var t in targetGraph.AllTargetsInOrder.Where(t => !t.Unlisted))
        {
            logger.LogInformation("  {Name} : {Description}", t.Name, t.Description);

            var triggersTargets = targetGraph.AllTargetsTriggerGraph.Edges
                .Where(e => e.Source == t)
                .Select(e => e.Target)
                .Where(triggered => !triggered.Unlisted)
                .Select(triggered => triggered.Name)
                .ToArray();

            var afterTargets = targetGraph.AllTargetsExecutionGraph.Edges
                .Where(e => e.Source == t)
                .Select(e => e.Target)
                .Where(triggered => !triggered.Unlisted)
                .Select(triggered => triggered.Name)
                .ToArray();

            var dependsOn = triggersTargets
                .Intersect(afterTargets)
                .ToArray();

            triggersTargets = triggersTargets
                .Except(dependsOn)
                .ToArray();

            afterTargets = afterTargets
                .Except(dependsOn)
                .ToArray();

            PrintList("Depends On", dependsOn);
            PrintList("Triggers", triggersTargets);
            PrintList("After", afterTargets);
        }
        
        // Cancel the build
        buildContext.Cancel();
    }

    /// <exception cref="OverflowException"></exception>
    void PrintList(string name, string[] list)
    {
        if (list.LongLength == 0)
        {
            return;
        }

        if (list.Sum(s => s.Length + 2) < 50)
        {
            logger.LogInformation("    - {Name}: [{Options}]", name, list.StringJoin(", "));
            return;
        }

        logger.LogInformation("    - {Name}:", name);
        foreach (var item in list)
        {
            logger.LogInformation("      - {Option}", item);
        }
    }
}