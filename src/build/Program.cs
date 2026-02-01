using build.Targets;
using xBuild.Build;
using xBuild.DesktopNotifications;
using xBuild.Serilog;
using xBuild.Shell;
using xBuild.UserInput;

var arguments = new[]
{
    // nameof(DotnetTargets.Build),
    // nameof(DotnetTargets.Test),
    // nameof(DotnetTargets.ClearNugetPackages),
    // nameof(DotnetTargets.NugetPush),
    // nameof(DotnetTargets.Pack),
    // nameof(StaticAnalysisTargets.Inspect),
    // nameof(StaticAnalysisTargets.ValidateLicenses),
    // nameof(StaticAnalysisTargets.PackageDescriptionCheck),
    // nameof(StaticAnalysisTargets.CountLines),
    nameof(Workflows.MergeCheck),
    // "--dry-run",
    "--plan",
    // "--list",
    // "--help"
};

return await new Build("src", defaultBuildConcurrency: BuildConcurrency.Parallel)
    .AddShell()
    .AddUserInput()
    .AddSerilog()
    .AddNotifications()
    .AddTargetsFromEntryAssembly()
    // .ExecuteAsync(args);
    .ExecuteAsync(arguments);