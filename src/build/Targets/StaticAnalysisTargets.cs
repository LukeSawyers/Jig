using AwesomeAssertions;
using AwesomeAssertions.Execution;
using build.NugetLicense;
using CliWrap;
using Microsoft.Build.Construction;
using Microsoft.CodeAnalysis.Sarif;
using Microsoft.CodeAnalysis.Sarif.Readers;
using Microsoft.Extensions.Logging;
using MoreLinq;
using Newtonsoft.Json;
using Jig.Apt;
using Jig.Lang;
using Jig.Shell;
using Jig.Targets;

namespace build.Targets;

public class StaticAnalysisTargets(DotnetTargets dotnetTargets) : ITargetProvider
{
    ITarget Cleanup => field ??= new Target(description: "Cleans up code")
        .ExecutesDotNetTool($"jetbrains.resharper.globaltools cleanupcode {BuildConstants.SolutionPath}");

    public ITarget GetInspectCodeResults => field ??= new Target(description: "Inspects code for issues")
        .After(() => Cleanup)
        .Unlisted()
        .ExecutesDotNetToolWithJsonOutput<SarifLog>(
            $"jetbrains.resharper.globaltools inspectcode {BuildConstants.SolutionPath} -stdout",
            new JsonSerializerSettings
            {
                ContractResolver = SarifContractResolverVersionOne.Instance
            },
            logging: ShellLoggingOptions.None
        );

    public ITarget Inspect => field ??= new Target(description: "Inspects code for issues")
        .DependentOn(() => GetInspectCodeResults)
        .Executes((ILogger logger, SarifLog log) =>
        {
            var results = log?.Runs
                .SelectMany(r => r.Results)
                .ToArray() ?? [];

            var warnings = results.Count(r => r.Level == FailureLevel.Warning);
            var errors = results.Count(r => r.Level == FailureLevel.Error);
            logger.LogInformation($"Inspect Results: {warnings} Warnings {errors} Errors");
        });

    public ITarget CheckLicenses => field ??= new Target(description: "Gets nuget package license validation results")
        .Unlisted()
        .DependentOn(() => dotnetTargets.Build)
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

    public ITarget ValidateLicenses => field ??= new Target(description: "Validates package licenses")
        .DependentOn(() => CheckLicenses)
        .Executes((ILogger logger, LicenseValidationResult[] validationResults) =>
        {
            validationResults.Should().NotBeNull()
                .And.Subject.Should().HaveCountGreaterThan(0, "there should be at least some license validation results");

            var errorResults = validationResults
                .Where(r => r.ValidationErrors is { Count: 0 })
                .ToArray();

            errorResults.ForEach(result => logger.LogError(
                "{PackageId} {PackageVersion} had validation errors:{Errors}",
                result.PackageId,
                result.PackageVersion,
                result.ValidationErrors!.StringJoin(e =>
                    $"""

                         Error: {e.Error}
                         Context: {e.Context}
                         
                     """
                )
            ));

            errorResults.Should().BeEmpty("there should not be any invalid licenses");
        });

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
                    var testProject = lines.Any(l => l.Contains("<IsTestProject>true"));
                    var notPackable = lines.Any(l => l.Contains("<IsPackable>false"));
                    if (testProject || notPackable)
                    {
                        continue;
                    }

                    var hasDescription = lines.Any(l => l.Contains("<Description>"));
                    hasDescription.Should().BeTrue($"project {project} should have a description");
                }
            }
        );
    public ITarget CountLines => field ??= new Target(description: "Counts lines of code")
        .If(OperatingSystem.IsLinux,
            t => t
                .RequireAptPackage("cloc", install: true)
                .Executes($"cloc . --include-lang=C#")
        );
}