namespace xBuild.Build.Hooks;

/// <summary>
/// Handler called once the build has completed
/// </summary>
public interface IBuildCompletedHandler
{
    ValueTask OnBuildCompleted();
}