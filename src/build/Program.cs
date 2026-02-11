using Jig.Build;
using Jig.DesktopNotifications;
using Jig.Serilog;
using Jig.Shell;
using Jig.UserInput;

return await new Build("src", defaultBuildConcurrency: BuildConcurrency.Parallel)
    .AddShell()
    .AddUserInput()
    .AddSerilog()
    .AddNotifications()
    .AddTargetsFromEntryAssembly()
    .ExecuteAsync(args);