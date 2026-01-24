using xBuild.Targets;

namespace xBuild.Build;

public interface IBuildContext
{
    BuildStatus Status { get; }
    
    TimeSpan ElapsedTime { get; }

    CancellationToken StoppingToken { get; }

    TargetGraph TargetGraph { get; }

    IDictionary<ITarget, TargetExecutionResult?> TargetResults { get; }
    
    IDictionary<Type, object> TargetOutputs { get; }
}