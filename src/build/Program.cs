using Jig.Build;
using Jig.DesktopNotifications;
using Jig.GitHubActions;
using Jig.Lang;
using Jig.Serilog;
using Jig.Shell;
using Jig.UserInput;

return await new Build("src", defaultBuildConcurrency: BuildConcurrency.Parallel)
    .AddShell()
    .AddSerilog()
    .If(!GitHubActionsEnvironment.IsRunningGitHubActions,
        b => b
            .AddUserInput()
            .AddNotifications()
    )
    .AddTargetsFromEntryAssembly()
    .ExecuteAsync(args);