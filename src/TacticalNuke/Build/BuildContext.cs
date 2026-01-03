using TacticalNuke.Targets;

namespace TacticalNuke.Build;

public class BuildContext(
    DirectoryInfo rootDirectory,
    CancellationToken stoppingToken
) : IBuildContext
{
    public DirectoryInfo RootDirectory { get; } = rootDirectory;
    public CancellationToken StoppingToken { get; } = stoppingToken;

    public ITarget? ExecutingTarget { get; set; }
}