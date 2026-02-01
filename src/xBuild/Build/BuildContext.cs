using System.Collections.Concurrent;
using xBuild.Targets;

namespace xBuild.Build;

public class BuildContext : IBuildContext
{
    /// <inheritdoc/>
    public BuildStatus Status { get; set; } = BuildStatus.NotStarted;

    /// <inheritdoc/>
    public TimeSpan ElapsedTime { get; set; }
    
    /// <inheritdoc/>
    public TargetGraph TargetGraph { get; internal set; } = new(new Dictionary<string, ITarget>(), []);

    /// <inheritdoc/>
    public IDictionary<ITarget, TargetExecutionResult?> TargetResults { get; } =
        new ConcurrentDictionary<ITarget, TargetExecutionResult?>();
    
    /// <inheritdoc/>
    public IDictionary<Type, object> TargetOutputs { get; } = new ConcurrentDictionary<Type, object>();

    /// <inheritdoc/>
    public CancellationToken BuildCancelled => _cts.Token;

    private readonly CancellationTokenSource _cts = new();
    
    /// <inheritdoc/>
    public void Cancel()
    {
        _cts.Cancel();
    }
}