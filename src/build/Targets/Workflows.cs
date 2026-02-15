using System.Diagnostics.Tracing;
using Jig.Targets;

namespace build.Targets;

public class Workflows(
    DotnetTargets dotnet,
    StaticAnalysisTargets staticAnalysis
) : ITargetProvider
{
    public ITarget Validate => field ??= new Target(description: "Runs all validation checks")
        .DependentOn(
            () => ValidateCode,
            () => InspectCode
        );
    
    public ITarget ValidateCode => field ??= new Target(description: "Validates code compiles and runs correctly")
        .DependentOn(
            () => dotnet.Build,
            () => dotnet.Test,
            () => dotnet.Pack
        );

    public ITarget InspectCode => field ??= new Target(description: "Runs code quality checks")
        .DependentOn(
            () => staticAnalysis.Inspect,
            () => staticAnalysis.ValidateLicenses,
            () => staticAnalysis.PackageDescriptionCheck,
            () => staticAnalysis.CountLines
        );

    public ITarget Deploy => field ?? new Target(description: "Runs actions required to publish artifacts")
        .DependentOn(() => dotnet.NugetPush);
}