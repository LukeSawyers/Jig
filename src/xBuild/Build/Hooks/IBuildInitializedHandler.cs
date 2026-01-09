namespace xBuild.Build.Hooks;

/// <summary>
/// Handler called once the build has been fully initialised, before targets have been implemented 
/// </summary>
public interface IBuildInitializedHandler
{
    ValueTask OnBuildInitialized();
}