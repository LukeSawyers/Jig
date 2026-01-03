using TacticalNuke.Build;

namespace TacticalNuke.GitLabRunner;

public static class GitLabBuildExtensions
{
    extension(TacticalNukeBuild build)
    {
        public TacticalNukeBuild AddGitLab()
        {
            return build;
        }
    }
}