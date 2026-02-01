using xBuild.Targets;

namespace xBuild.Build.Extension;

/// <summary>
/// Handler called after a target has been executed
/// </summary>
public interface ITargetCompletedHandler
{
    ValueTask OnTargetCompleted(ITarget target, TargetExecutionResult result);
}