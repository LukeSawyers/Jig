using System.Collections.Concurrent;
using xBuild.Targets;

namespace xBuild.Build;

public class BuildContext(
    CancellationToken stoppingToken
) : IBuildContext
{
    public BuildStatus Status { get; set; } = BuildStatus.NotStarted;
    
    public TimeSpan ElapsedTime { get; set; }

    public CancellationToken StoppingToken { get; } = stoppingToken;

    public TargetGraph TargetGraph { get; internal set; } = new(new Dictionary<string, ITarget>());

    public IDictionary<ITarget, TargetExecutionResult?> Targets { get; } = new ConcurrentDictionary<ITarget, TargetExecutionResult?>();
}