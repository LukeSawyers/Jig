using TacticalNuke.Targets;

namespace TacticalNuke.Build;

public interface IBuildContext
{
    DirectoryInfo RootDirectory { get; }
    CancellationToken StoppingToken { get; }

    ITarget? ExecutingTarget { get; }
}