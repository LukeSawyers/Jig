using AwesomeAssertions;
using Jig.GitHubActions;
using Jig.Lang;
using Jig.Shell;
using Jig.Targets;

namespace build.Targets;

public class GitHubTargets(
    GithubOptions ghOptions,
    DotnetTargets dotnetTargets
) : ITargetProvider
{
    public Target GhCreateRelease => field ??= new Target(description: "Creates a release in github")
        .After(() => dotnetTargets.Pack)
        .If(GitHubActionsEnvironment.IsRunningGitHubActions,
            t => t
                .ExecutesExpression(() => ghOptions.GithubToken.Value.Should().NotBeNull())
                .Executes(
                //language=bash
                $$"""
                  GH_TOKEN={{ghOptions.GithubToken.Value}}
                  gh release create {{GitHubActionsEnvironment.RefName}}
                  --title "Jig Release {{GitHubActionsEnvironment.RefName}}"
                  --target {{GitHubActionsEnvironment.Sha}}
                  --generate-notes
                  ./**/*.nupkg
                  """
            )
        );
}