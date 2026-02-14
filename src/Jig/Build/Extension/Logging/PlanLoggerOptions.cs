using Jig.Options;

namespace Jig.Build.Extension.Logging;

public class PlanLoggerOptions : IOptionsProvider
{
    public BuildOption<bool> Plan { get; } = new(
        false,
        description: "Print the build plan when the build starts"
    );
}