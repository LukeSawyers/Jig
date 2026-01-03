using Microsoft.CodeAnalysis.Sarif;
using Microsoft.CodeAnalysis.Sarif.Readers;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using TacticalNuke;
using TacticalNuke.Build;
using TacticalNuke.Commands;
using TacticalNuke.Targets;

namespace _build.Targets;

// Multiple target classes supported
public class InspectionTargets(
    ILogger logger
) // Class dependency injection supported,
{
    private ITarget RestoreDotnetTools => field ??= new Target(description: "Restores dotnet tools")
        // Don't show the target in the CLI
        .Unlisted()
        .Executes("dotnet tool restore --verbosity minimal");

    private ITarget Cleanup => field ??= new Target(description: "Cleans up code")
        .DependsOn(RestoreDotnetTools)
        .Executes($"dotnet jb cleanupcode {BuildTargets.SolutionPath}");

    private ITarget Inspect => field ??= new Target(description: "Cleans up code")
        .DependsOn(RestoreDotnetTools)
        .After(Cleanup)
        // Targets support delegate execution with dependency injection
        .Executes(async (Shell shell, IBuildContext buildContext) =>
        {
            // Run shell executions in targets
            var logContents = await shell
                .Command($"dotnet jb inspectcode {BuildTargets.SolutionPath} -stdout")
                .ExecuteAndCaptureOutputAsync(buildContext.StoppingToken)
                .ToArrayAsync()
                .LetAsync(lines => lines.StringJoin(Environment.NewLine));

            var settings = new JsonSerializerSettings
            {
                ContractResolver = SarifContractResolverVersionOne.Instance
            };

            // Sarif format serialization provided separately by Sarif.Sdk
            var log = JsonConvert.DeserializeObject<SarifLog>(logContents, settings);
            var results = log?.Runs
                .SelectMany(r => r.Results)
                .ToArray() ?? [];

            var warnings = results.Count(r => r.Level == FailureLevel.Warning);
            var errors = results.Count(r => r.Level == FailureLevel.Error);

            if (warnings > 0) throw new Exception("Warnings found");

            logger.LogInformation(
                "Inspect Results: {Warnings} Warnings {Errors} Errors",
                warnings,
                errors
            );
        });
}