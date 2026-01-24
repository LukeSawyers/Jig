using _build.NugetLicense;
using AwesomeAssertions;
using AwesomeAssertions.Execution;
using CliWrap;
using Microsoft.Build.Construction;
using Microsoft.CodeAnalysis.Sarif;
using Microsoft.CodeAnalysis.Sarif.Readers;
using Newtonsoft.Json;
using xBuild;
using xBuild.Apt;
using xBuild.Logging;
using xBuild.Shell;
using xBuild.Targets;

namespace _build.Targets;

public class StaticAnalysisTargets : ITargetProvider
{
    ITarget Cleanup => field ??= new Target(description: "Cleans up code")
        .ExecutesDotNetTool($"jetbrains.resharper.globaltools cleanupcode {BuildConstants.SolutionPath}");

    public ITarget Inspect => field ??= new Target(description: "Inspects code for issues")
        .After(() => Cleanup)
        .Executes(async (ITargetLogger logger, TargetShell shell, CancellationToken stoppingToken) =>
        {
            var log = await shell
                .DotnetToolCommand($"jetbrains.resharper.globaltools inspectcode {BuildConstants.SolutionPath} -stdout")
                .ExecuteAndCaptureJsonOutputAsync<SarifLog>(
                    new JsonSerializerSettings
                    {
                        ContractResolver = SarifContractResolverVersionOne.Instance
                    },
                    stoppingToken
                );

            var results = log?.Runs
                .SelectMany(r => r.Results)
                .ToArray() ?? [];

            var warnings = results.Count(r => r.Level == FailureLevel.Warning);
            var errors = results.Count(r => r.Level == FailureLevel.Error);
            logger.LogInformation($"Inspect Results: {warnings} Warnings {errors} Errors");
        });

    public ITarget CheckLicenses => field ??= new Target(description: "Checks nuget package licenses")
        .ExecutesDotNetToolWithJsonOutput<LicenseValidationResult[]>(
            $"""
             nuget-license -i {BuildConstants.SolutionPath} 
             --include-transitive 
             --output JsonPretty
             --allowed-license-types allowed-licenses.json
             -override override-licenses.json
             """,
            validation: CommandResultValidation.None
        );

    public ITarget ValidateLicenses => field ??= new Target(description: "Validates nuget package licenses")
        .DependsOn(() => CheckLicenses)
        .Executes((ITargetLogger logger, LicenseValidationResult[] validationResults) =>
            {
                validationResults.Should().NotBeNull()
                    .And.Subject.Any().Should().BeTrue("there should be at least some license validation results");

                var errorResults = validationResults
                    .Where(r => r.ValidationErrors?.Any() == true)
                    .ToArray();

                foreach (var result in errorResults)
                {
                    var validationErrorStrings = result.ValidationErrors
                        ?.StringJoin(e =>
                            $"""

                                 Error: {e.Error}
                                 Context: {e.Context}
                                 
                             """
                        );

                    logger.LogError(
                        $"{result.PackageId} {result.PackageVersion} had validation errors:{validationErrorStrings}"
                    );
                }

                errorResults.Should().BeEmpty("there should not be any invalid licenses");
            }
        );

    public ITarget PackageDescriptionCheck => field ??= new Target(description: "Checks nuget package licenses")
        .Executes(() =>
            {
                var projects = BuildConstants.Solution.ProjectsInOrder
                    .Where(p => p.ProjectType.HasFlag(SolutionProjectType.KnownToBeMSBuildFormat))
                    .Select(p => p.AbsolutePath)
                    .ToArray();

                using var _ = new AssertionScope();

                foreach (var project in projects)
                {
                    var lines = File.ReadAllLines(project);
                    var notPackable = lines.Any(l => l.Contains("<IsPackable>false"));
                    if (notPackable)
                    {
                        continue;
                    }

                    var hasDescription = File.ReadAllLines(project).Any(l => l.Contains("<Description>"));
                    hasDescription.Should().BeTrue($"project {project} should have a description");
                }
            }
        );

    public ITarget CountLines => field ??= new Target(description: "Counts lines of code")
        .RequireAptPackage("cloc")
        .Executes($"cloc . --include-lang=C#");
}