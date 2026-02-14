using Jig.Lang;
using Jig.Options;
using Microsoft.Extensions.Logging;

namespace Jig.Build.Extension.Logging;

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