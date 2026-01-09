using _build.NugetLicense;
using AwesomeAssertions;
using AwesomeAssertions.Execution;
using CliWrap;
using Microsoft.Build.Construction;
using Microsoft.CodeAnalysis.Sarif;
using Microsoft.CodeAnalysis.Sarif.Readers;
using Newtonsoft.Json;
using Polly;
using Polly.Retry;
using xBuild;
using xBuild.Apt;
using xBuild.Logging;
using xBuild.Options;
using xBuild.Polly;
using xBuild.Shell;
using xBuild.Targets;

namespace _build.Targets;

public class Targets : ITargetProvider
{
    public const string SolutionPath = "xBuild.sln";

    SolutionFile Solution => field ??= SolutionFile.Parse(Path.Combine(Directory.GetCurrentDirectory(), SolutionPath));

    BuildOption<string> Verbosity { get; } = new("minimal", description: "Verbosity for dotnet tasks");

    BuildOption<bool> Retry { get; } = new(false, description: "Runs relevant targets in a retry loop");

    BuildOption<string?> NugetApiKey { get; } = new(null, sensitive: true, description: "API key used to push nuget packages");

    // Build & Test
    public ITarget DotNetBuild => field ??= new Target(description: "Builds the solution")
        .Executes($"dotnet build {SolutionPath} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    public ITarget DotNetTest => field ??= new Target(description: "Tests the solution")
        .After(() => DotNetBuild)
        .Executes($"dotnet test {SolutionPath} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    public ITarget DotNetPack => field ??= new Target(description: "Tests the solution")
        .After(() => DotNetTest)
        .Executes($"dotnet pack {SolutionPath} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    public ITarget NugetPush => field ??= new Target(description: "Tests the solution")
        .DependsOn(() => DotNetPack)
        .Executes(() => NugetApiKey.Value.Should().NotBeNull())
        .Executes(
            $"""
             dotnet nuget push **/xBuild*.nupkg 
             --api-key {NugetApiKey} 
             --skip-duplicate 
             --source https://api.nuget.org/v3/index.json
             """
        ).WithResilience(ApplyRetry);

    // Static Analysis
    ITarget Cleanup => field ??= new Target(description: "Cleans up code")
        .ExecutesDotNetTool($"jetbrains.resharper.globaltools cleanupcode {SolutionPath}");

    public ITarget Inspect => field ??= new Target(description: "Inspects code for issues")
        .After(() => Cleanup)
        .Executes(async (ITargetLogger logger, TargetShell shell, CancellationToken stoppingToken) =>
        {
            var log = await shell
                .DotnetToolCommand($"jetbrains.resharper.globaltools inspectcode {SolutionPath} -stdout")
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
            logger.LogInformationFormat($"Inspect Results: {warnings} Warnings {errors} Errors");
        });

    public ITarget LicenseCheck => field ??= new Target(description: "Checks nuget package licenses")
        .Executes(async (ITargetLogger logger, TargetShell shell, CancellationToken stoppingToken) =>
            {
                var results = await shell.DotnetToolCommand(
                        $"""
                         nuget-license -i {SolutionPath} 
                         --include-transitive 
                         --output JsonPretty 
                         --allowed-license-types allowed-licenses.json
                         -override override-licenses.json
                         """
                    )
                    .WithValidation(CommandResultValidation.None)
                    .ExecuteAndCaptureJsonOutputAsync<LicenseValidationResult[]>(stoppingToken);

                results.Should().NotBeNull()
                    .And.Subject.Any().Should().BeTrue("there should be at least some license validation results");

                var errorResults = results
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

                    logger.LogErrorFormat(
                        $"{result.PackageId} {result.PackageVersion} had validation errors:{validationErrorStrings}"
                    );
                }

                errorResults.Should().BeEmpty("there should not be any invalid licenses");
            }
        )
        .WithResilience(ApplyRetry);

    public ITarget PackageDescriptionCheck => field ??= new Target(description: "Checks nuget package licenses")
        .Executes(() =>
            {
                var projects = Solution.ProjectsInOrder
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

    public ResiliencePipelineBuilder ApplyRetry(ResiliencePipelineBuilder b)
        => Retry
            ? b.AddRetry(new RetryStrategyOptions
            {
                MaxRetryAttempts = int.MaxValue,
            })
            : b;
}