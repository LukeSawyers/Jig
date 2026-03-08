using Jig.Options;

namespace Jig.GitHubActions;

public class GithubOptions : IOptionsProvider
{
    public BuildOption<string?> GithubToken { get; } = new(
        defaultValue: null,
        sensitive: true,
        description: "Github Token"
    );
}