using Jig.Build;

namespace Jig.GitHubActions;

public static class GitHubBuildExtensions
{
    extension<T>(T build) where T : IBuild
    {
        public T AddGitHubActions()
        {
            build.AddBuildOptions<GithubOptions>();
            return build;
        }
    }
}