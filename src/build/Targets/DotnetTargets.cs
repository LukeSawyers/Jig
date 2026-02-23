using AwesomeAssertions;
using Jig.Lang;
using Jig.Options;
using Jig.Polly;
using Jig.Shell;
using Jig.Targets;
using MoreLinq;
using Polly;
using Polly.Retry;

namespace build.Targets;

public class DotnetTargets : ITargetProvider
{
    public BuildOption<string?> FromRef { get; } = new(null, description: "The source ref to use for monorepo diffing");
    public BuildOption<string?> ToRef { get; } = new(null, description: "The target ref to use for monorepo diffing");
    
    public BuildOption<string> Verbosity { get; } = new("minimal", description: "Verbosity for dotnet tasks");

    public BuildOption<bool> Retry { get; } = new(false, description: "Runs relevant targets in a retry loop");

    public BuildOption<string?> NugetApiKey { get; } = new(null, sensitive: true, description: "API key used to push nuget packages");

    private string? FromRefArgument => FromRef.Value?.Let(r => $"--from {r}");
    private string? ToRefArgument => ToRef.Value?.Let(r => $"--to {r}");
    
    // Build & Test
    public ITarget Build => field ??= new Target(description: "Builds the solution")
        .ExecutesDotNetTool($"dotnet-monorepo build {FromRefArgument} {ToRefArgument} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    public ITarget Test => field ??= new Target(description: "Tests the solution")
        .After(() => Build)
        .ExecutesDotNetTool($"dotnet-monorepo test {FromRefArgument} {ToRefArgument} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    // Packaging
    public ITarget ClearNugetPackages => field ??= new Target(description: "Clears nuget packages from the directory")
        .Before(() => Build)
        .ExecutesExpression(() => new DirectoryInfo(Directory.GetCurrentDirectory())
            .GetFiles("Jig*.nupkg", SearchOption.AllDirectories)
            .ForEach(f => f.Delete()));

    public ITarget Pack => field ??= new Target(description: "Generates nuget packages")
        .DependentOn(() => ClearNugetPackages)
        .After(() => Test)
        .ExecutesDotNetTool($"dotnet-monorepo pack {FromRefArgument} {ToRefArgument} --verbosity {Verbosity} --configuration Release")
        .WithResilience(ApplyRetry);

    public ITarget NugetPush => field ??= new Target(description: "Pushes nuget packages to nuget.org")
        .DependentOn(() => Pack)
        .ExecutesExpression(() => NugetApiKey.Value.Should().NotBeNull())
        .ExecutesDefaultShell(
            $"""
             dotnet nuget push **/Jig*.nupkg 
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