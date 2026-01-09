using _build.Targets;
using xBuild.Build;
using xBuild.DesktopNotifications;
using xBuild.Serilog;
using xBuild.Shell;
using xBuild.Spectre;
using xBuild.UserInput;

var arguments = new[]
{
    // "LicenseCheck",
    // "CountLines",
    // "Inspect",
    // "MergeCheck",
    // "DotNetTest",
    "PackageDescriptionCheck",
    // "Pack",
    // "--help"
};

await new Build("src", defaultBuildConcurrency: BuildConcurrency.Parallel)
    .AddShell()
    .AddUserInput()
    .AddSerilog()
    // .AddSpectre()
    .AddNotifications()
    .AddTargets<Workflows>()
    .AddTargets<Targets>()
    .ExecuteAsync(args);
    // .ExecuteAsync(arguments);