using xBuild.Targets;

namespace _build.Targets;

public class Workflows(
    DotnetTargets dotnet,
    StaticAnalysisTargets staticAnalysis
) : ITargetProvider
{
    public ITarget MergeCheck => field ??= new Target(description: "Runs required merge checks")
        .DependsOn(
            () => dotnet.Build,
            () => dotnet.Test,
            () => dotnet.Pack,
            () => staticAnalysis.Inspect,
            () => staticAnalysis.ValidateLicenses,
            () => staticAnalysis.PackageDescriptionCheck,
            () => staticAnalysis.CountLines
        );

    public ITarget Deploy => field ?? new Target(description: "Runs actions required to publish artifacts")
        .DependsOn(() => dotnet.NugetPush
        );
}