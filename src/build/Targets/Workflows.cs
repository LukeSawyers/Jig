using Jig.Targets;

namespace build.Targets;

public class Workflows(
    DotnetTargets dotnet,
    StaticAnalysisTargets staticAnalysis
) : ITargetProvider
{
    public ITarget MergeCheck => field ??= new Target(description: "Runs required merge checks")
        .DependentOn(
            () => dotnet.Build,
            () => dotnet.Test,
            () => dotnet.Pack,
            () => staticAnalysis.Inspect,
            () => staticAnalysis.ValidateLicenses,
            () => staticAnalysis.PackageDescriptionCheck,
            () => staticAnalysis.CountLines
        );

    public ITarget Deploy => field ?? new Target(description: "Runs actions required to publish artifacts")
        .DependentOn(() => dotnet.NugetPush);
}