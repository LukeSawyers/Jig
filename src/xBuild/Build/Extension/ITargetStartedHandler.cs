using xBuild.Targets;

namespace xBuild.Build.Extension;

/// <summary>
/// Handler called before a target is executed
/// </summary>
public interface ITargetStartedHandler
{
    ValueTask OnTargetStarted(ITarget target);
}