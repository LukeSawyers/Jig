namespace Jig.Build.Extension;

/// <summary>
/// Handler called once the build has completed
/// </summary>
public interface IBuildCompletedHandler
{
    ValueTask OnBuildCompleted();
}