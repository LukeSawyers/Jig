using JetBrains.Annotations;
using Jig.Lang;

namespace Jig.GitHubActions;

/// <summary>
/// Environment variables when running in github actions according to the
/// <a href="https://docs.github.com/en/actions/reference/workflows-and-actions/variables">documentation</a>.
/// </summary>
[PublicAPI]
public class GitHubActionsEnvironment
{
    /// <summary>
    ///     The name of the action currently running, or the id of a step.
    /// </summary>
    public string? Action => Environment.GetEnvironmentVariable("GITHUB_ACTION");

    /// <summary>
    ///     The path where an action is located. This property is only supported in composite actions.
    /// </summary>
    public string? ActionPath => Environment.GetEnvironmentVariable("GITHUB_ACTION_PATH");

    /// <summary>
    ///     For a step executing an action, this is the owner and repository name of the action.
    /// </summary>
    public string? ActionRepository => Environment.GetEnvironmentVariable("GITHUB_ACTION_REPOSITORY");

    /// <summary>
    ///     True when GitHub Actions is running the workflow. Y
    /// </summary>
    public static bool IsRunningGitHubActions =>
        Environment.GetEnvironmentVariable("GITHUB_ACTIONS")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The name of the person or app that initiated the workflow.
    /// </summary>
    /// <example>octocat</example>
    public string? Actor => Environment.GetEnvironmentVariable("GITHUB_ACTOR");

    /// <summary>
    ///     The account ID of the person or app that triggered the initial workflow run.
    /// </summary>
    public string? ActorId => Environment.GetEnvironmentVariable("GITHUB_ACTOR_ID");

    /// <summary>
    ///     Returns the API URL.
    /// </summary>
    public string? ApiUrl => Environment.GetEnvironmentVariable("GITHUB_API_URL");

    /// <summary>
    ///     Only set for forked repositories. The branch of the base repository.
    /// </summary>
    public string? BaseRef => Environment.GetEnvironmentVariable("GITHUB_BASE_REF");

    /// <summary>
    ///     The path on the runner to the file that sets variables from workflow commands.
    /// </summary>
    // TODO: File Info
    public string? Env => Environment.GetEnvironmentVariable("GITHUB_ENV");

    /// <summary>
    ///     The name of the webhook event that triggered the workflow.
    /// </summary>
    public string? EventName => Environment.GetEnvironmentVariable("GITHUB_EVENT_NAME");

    /// <summary>
    ///     true if the <see cref="EventName"/> is a pull request
    /// </summary>
    public bool IsPullRequest => EventName == "pull_request";

    /// <summary>
    ///     The path of the file with the complete webhook event payload.
    /// </summary>
    /// <example>/github/workflow/event.json</example>
    // TODO: File Info
    public string? EventPath => Environment.GetEnvironmentVariable("GITHUB_EVENT_PATH");

    /// <summary>
    ///     Returns the GraphQL API URL.
    /// </summary>
    public string? GraphQLUrl => Environment.GetEnvironmentVariable("GITHUB_GRAPHQL_URL");

    /// <summary>Only set for forked repositories. The branch of the head repository.</summary>
    public string? HeadRef => Environment.GetEnvironmentVariable("GITHUB_HEAD_REF");

    /// <summary>
    ///     The job_id of the current job.
    /// </summary>
    public string? Job => Environment.GetEnvironmentVariable("GITHUB_JOB");

    /// <summary>
    /// The path on the runner to the file that sets the current step's outputs from workflow commands.
    /// </summary>
    // TODO: File Info
    public string? Output => Environment.GetEnvironmentVariable("GITHUB_OUTPUT");

    /// <summary>
    ///     The path on the runner to the file that sets system PATH variables from workflow commands.
    /// </summary>
    // TODO: File Info
    public string? Path => Environment.GetEnvironmentVariable("GITHUB_PATH");

    /// <summary>
    ///     The fully-formed ref of the branch or tag that triggered the workflow run.
    ///     For workflows triggered by <c>push</c>, this is the branch or tag ref that was pushed.
    ///     For workflows triggered by <c>pull_request</c>, this is the pull request merge branch.
    ///     For workflows triggered by <c>release</c>, this is the release tag created.
    ///     For other triggers, this is the branch or tag ref that triggered the workflow run.
    ///     This is only set if a branch or tag is available for the event type.
    ///     The ref given is fully-formed, meaning that for branches the format is <c>refs/heads/&lt;branch_name&gt;</c>,
    ///     for pull requests it is <c>refs/pull/&lt;pr_number&gt;/merge</c>,
    ///     and for tags it is <c>refs/tags/&lt;tag_name&gt;</c>.
    /// </summary>
    /// <example>refs/heads/feature-branch-1</example>
    public string? Ref => Environment.GetEnvironmentVariable("GITHUB_REF");

    /// <summary>
    ///     The short ref name of the branch or tag that triggered the workflow run.
    ///     This value matches the branch or tag name shown on GitHub.
    /// </summary>
    /// <example>feature-branch-1</example>
    public string? RefName => Environment.GetEnvironmentVariable("GITHUB_REF_NAME");

    /// <summary>
    ///     true if branch protections or rulesets are configured for the ref that triggered the workflow run.
    /// </summary>
    public bool RefProtected => Environment.GetEnvironmentVariable("GITHUB_REF_PROTECTED")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The type of ref that triggered the workflow run.
    ///     Valid values are <c>branch</c> or <c>tag</c>.
    /// </summary>
    // TODO: Enum would be suitable here
    public string? RefType => Environment.GetEnvironmentVariable("GITHUB_REF_TYPE");

    /// <summary>
    ///     The owner and repository name.
    /// </summary>
    /// <example>octocat/Hello-World</example>
    public string? Repository => Environment.GetEnvironmentVariable("GITHUB_REPOSITORY");

    /// <summary>
    ///     The ID of the repository.
    /// </summary>
    /// <example>123456789</example>
    public long? RepositoryId => Environment.GetEnvironmentVariable("GITHUB_REPOSITORY_ID").TryParseLong();

    /// <summary>
    ///     The owner name.
    /// </summary>
    /// <example>octocat</example>
    public string? RepositoryOwner => Environment.GetEnvironmentVariable("GITHUB_REPOSITORY_OWNER");

    /// <summary>
    ///     The repository owner's account ID. For example.
    /// </summary>
    /// <example>123456789</example>
    public long? RepositoryOwnerId => Environment.GetEnvironmentVariable("GITHUB_REPOSITORY_OWNER_ID").TryParseLong();

    /// <summary>
    ///     The number of days that workflow run logs and artifacts are kept.
    /// </summary>
    /// <example>90</example>
    public long? RetentionDays => Environment.GetEnvironmentVariable("GITHUB_RETENTION_DAYS").TryParseLong();

    /// <summary>
    ///     A unique number for each attempt of a particular workflow run in a repository.
    ///     This number begins at 1 for the workflow run's first attempt, and increments with each re-run.
    /// </summary>
    /// <example>3</example>
    public long? RunAttempt => Environment.GetEnvironmentVariable("GITHUB_RUN_ATTEMPT").TryParseLong();

    /// <summary>
    ///     A unique number for each workflow run within a repository.
    ///     This number does not change if you re-run the workflow run. For example, 1658821493.
    /// </summary>
    public long? RunId => Environment.GetEnvironmentVariable("GITHUB_RUN_ID").TryParseLong();

    /// <summary>
    ///     A unique number for each run of a particular workflow in a repository.
    ///     This number begins at 1 for the workflow's first run, and increments with each new run.
    ///     This number does not change if you re-run the workflow run.
    /// </summary>
    /// <example>3</example>
    public long? RunNumber => Environment.GetEnvironmentVariable("GITHUB_RUN_NUMBER").TryParseLong();

    /// <summary>
    ///     The URL of the GitHub server. 
    /// </summary>
    /// <example>https://github.com</example>
    public string? ServerUrl => Environment.GetEnvironmentVariable("GITHUB_SERVER_URL");

    /// <summary>
    ///     The commit SHA that triggered the workflow.
    /// </summary>
    /// <example>ffac537e6cbbf934b08745a378932722df287a53</example>
    public string? Sha => Environment.GetEnvironmentVariable("GITHUB_SHA");

    /// <summary>
    ///     The path on the runner to the file that contains job summaries from workflow commands.
    /// </summary>
    // TODO: File Info
    public string? StepSummaryFile => Environment.GetEnvironmentVariable("GITHUB_STEP_SUMMARY");

    /// <summary>
    ///     The username of the user that initiated the workflow run.
    ///     If the workflow run is a re-run, this value may differ from github.actor. 
    /// </summary>
    public string? TriggeringActor => Environment.GetEnvironmentVariable("GITHUB_TRIGGERING_ACTOR");

    /// <summary>
    ///     The name of the workflow.
    /// </summary>
    public string? Workflow => Environment.GetEnvironmentVariable("GITHUB_WORKFLOW");

    /// <summary>
    ///     The ref path to the workflow.
    /// </summary>
    public string? WorkflowRef => Environment.GetEnvironmentVariable("GITHUB_WORKFLOW_REF");

    /// <summary>
    ///     The commit SHA for the workflow file.
    /// </summary>
    public string? WorkflowSha => Environment.GetEnvironmentVariable("GITHUB_WORKFLOW_SHA");

    /// <summary>
    ///     The GitHub workspace directory path.
    ///     The workspace directory contains a subdirectory with a copy of your repository if your workflow uses the <c>actions/checkout</c> action.
    ///     If you don't use the <c>actions/checkout</c> action, the directory will be empty.
    /// </summary>
    /// <example>/home/runner/work/my-repo-name/my-repo-name</example>
    public string? Workspace => Environment.GetEnvironmentVariable("GITHUB_WORKSPACE");

    /// <summary>
    ///     The architecture of the runner executing the job.
    /// Possible values are X86, X64, ARM, or ARM64.
    /// </summary>
    public string? RunnerArch => Environment.GetEnvironmentVariable("RUNNER_ARCH");

    /// <summary>
    ///     True if debug logging is enable.
    ///     It can be useful as an indicator to enable additional debugging or verbose logging in your own job steps.
    /// </summary>
    public bool RunnerDebug => Environment.GetEnvironmentVariable("RUNNER_DEBUG") == "1";

    /// <summary>
    ///     The environment of the runner executing the job.
    ///     Possible values are: github-hosted for GitHub-hosted runners provided by GitHub,
    ///     and self-hosted for self-hosted runners configured by the repository owner.
    /// </summary>
    public string? RunnerEnvironment => Environment.GetEnvironmentVariable("RUNNER_ENVIRONMENT");

    /// <summary>
    ///     The name of the runner executing the job.
    ///     This name may not be unique in a workflow run as runners at the repository and organization levels could use the same name.
    /// </summary>
    /// <example>Hosted Agent</example>
    public string? RunnerName => Environment.GetEnvironmentVariable("RUNNER_NAME");

    /// <summary>
    ///     The operating system of the runner executing the job.
    ///     Possible values are Linux, Windows, or macOS. For example, Windows
    /// </summary>
    public string? RunnerOS => Environment.GetEnvironmentVariable("RUNNER_OS");

    /// <summary>
    ///     The path to a temporary directory on the runner.
    ///     This directory is emptied at the beginning and end of each job.
    ///     Note that files will not be removed if the runner's user account does not have permission to delete them.
    /// </summary>
    /// <example>D:\a\_temp</example>
    public string? RunnerTemp => Environment.GetEnvironmentVariable("RUNNER_TEMP");

    /// <summary>
    ///     The path to the directory containing preinstalled tools for GitHub-hosted runners.
    /// </summary>
    /// <example>C:\hostedtoolcache\windows</example>
    public string? RunnerToolCache => Environment.GetEnvironmentVariable("RUNNER_TOOL_CACHE");
}