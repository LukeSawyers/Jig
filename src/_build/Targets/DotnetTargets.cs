using AwesomeAssertions;
using Polly;
using Polly.Retry;
using xBuild.Options;
using xBuild.Polly;
using xBuild.Shell;
using xBuild.Targets;

namespace _build.Targets;

public class DotnetTargets(DotnetToolsGeneration dotnetToolsGeneration) : ITargetProvider
{
    BuildOption<string> Verbosity { get; } = new("minimal", description: "Verbosity for dotnet tasks");

    BuildOption<bool> Retry { get; } = new(false, description: "Runs relevant targets in a retry loop");

    BuildOption<string?> NugetApiKey { get; } = new(null, sensitive: true, description: "API key used to push nuget packages");

    // Build & Test
    public ITarget Build => field ??= new Target(description: "Builds the solution")
        .After(() => dotnetToolsGeneration.GenerateDotNetToolsExtensions)
        .Executes($"dotnet build {BuildConstants.SolutionPath} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    public ITarget Test => field ??= new Target(description: "Tests the solution")
        .After(
            () => dotnetToolsGeneration.GenerateDotNetToolsExtensions,
            () => Build
        )
        .Executes($"dotnet test {BuildConstants.SolutionPath} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    public ITarget Pack => field ??= new Target(description: "Tests the solution")
        .After(
            () => dotnetToolsGeneration.GenerateDotNetToolsExtensions,
            () => Test
        )
        .Executes($"dotnet pack {BuildConstants.SolutionPath} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    public ITarget NugetPush => field ??= new Target(description: "Tests the solution")
        .DependsOn(() => Pack)
        .Executes(() => NugetApiKey.Value.Should().NotBeNull())
        .Executes(
            $"""
             dotnet nuget push **/xBuild*.nupkg 
             --api-key {NugetApiKey} 
             --skip-duplicate 
             --source https://api.nuget.org/v3/index.json
             """
        ).WithResilience(ApplyRetry);

    public ResiliencePipelineBuilder ApplyRetry(ResiliencePipelineBuilder b)
        => Retry
            ? b.AddRetry(new RetryStrategyOptions
            {
                MaxRetryAttempts = int.MaxValue,
            })
            : b;
}