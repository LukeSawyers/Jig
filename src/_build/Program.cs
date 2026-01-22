using _build.Targets;
using xBuild.Build;
using xBuild.DesktopNotifications;
using xBuild.Serilog;
using xBuild.Shell;
using xBuild.Spectre;
using xBuild.UserInput;

var arguments = new[]
{
    nameof(DotnetTargets.Pack),
    nameof(DotnetTargets.Test),
    nameof(StaticAnalysisTargets.Inspect),
    nameof(StaticAnalysisTargets.LicenseCheck),
    nameof(StaticAnalysisTargets.PackageDescriptionCheck),
    nameof(StaticAnalysisTargets.CountLines),
    nameof(Workflows.MergeCheck),
    // "--help"
};

await new Build("src", defaultBuildConcurrency: BuildConcurrency.Parallel)
    .AddShell()
    .AddUserInput()
    .AddSerilog()
    // .AddSpectre()
    .AddNotifications()
    .AddTargetsFromEntryAssembly()
    // .AddTargets<Workflows>()
    // .AddTargets<DotnetTargets>()
    .ExecuteAsync(args);
    // .ExecuteAsync(arguments);