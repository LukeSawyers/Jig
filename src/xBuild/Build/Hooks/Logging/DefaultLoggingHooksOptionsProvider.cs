using System.CommandLine;
using xBuild.Options;

namespace xBuild.Build.Hooks.Logging;

public class DefaultLoggingHooksOptionsProvider : IOptionsProvider
{
    public BuildOption<bool> NoPlan { get; } = new(
        false,
        new Option<bool>("--no-plan")
        {
            Description = "Don't print the build plan when the build starts"
        }
    );
}