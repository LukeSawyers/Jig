using xBuild.Targets;

namespace _build.Targets;

public class Workflows(Targets targets) : ITargetProvider
{
    ITarget MergeCheck => field ??= new Target(description: "Runs required merge checks")
        .DependsOn(
            () => targets.DotNetBuild,
            () => targets.DotNetTest,
            () => targets.DotNetPack,
            () => targets.Inspect,
            () => targets.LicenseCheck,
            () => targets.PackageDescriptionCheck,
            () => targets.CountLines
        );

    private ITarget Deploy => field ?? new Target(description: "Runs actions required to publish artifacts")
        .DependsOn(
            () => targets.NugetPush
        );
}