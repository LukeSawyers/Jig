using build.Targets;
using Jig.Build;
using Jig.DesktopNotifications;
using Jig.Serilog;
using Jig.Shell;
using Jig.UserInput;

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