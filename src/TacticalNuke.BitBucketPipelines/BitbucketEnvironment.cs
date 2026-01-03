// Acquired originally from the NUKE Build project.
// Redistributed under the MIT License.
//
// Original Boilerplate:
// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace TacticalNuke.BitBucketPipelines;

/// <summary>
///     Interface according to the
///     <a href="https://support.atlassian.com/bitbucket-cloud/docs/variables-and-secrets/">official website</a>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static class BitbucketEnvironment
{
    [UsedImplicitly] internal static bool IsRunningBitbucket => PipelineUuid != null;

    /// <summary>
    ///     The unique identifier for a build. It increments with each build and can be used to create unique artifact names.
    /// </summary>
    public static long? BuildNumber => Environment.GetEnvironmentVariable("BITBUCKET_BUILD_NUMBER")?.Let(long.Parse);

    /// <summary>
    ///     The absolute path of the directory that the repository is cloned into within the Docker container.
    /// </summary>
    public static string? CloneDirectory => Environment.GetEnvironmentVariable("BITBUCKET_CLONE_DIR");

    /// <summary>
    ///     The commit hash of a commit that kicked off the build.
    /// </summary>
    public static string? Commit => Environment.GetEnvironmentVariable("BITBUCKET_COMMIT");

    /// <summary>
    ///     The name of the workspace in which the repository lives.
    /// </summary>
    public static string? Workspace => Environment.GetEnvironmentVariable("BITBUCKET_WORKSPACE");

    /// <summary>
    ///     The URL-friendly version of a repository name.
    /// </summary>
    public static string? RepositorySlug => Environment.GetEnvironmentVariable("BITBUCKET_REPO_SLUG");

    /// <summary>
    ///     The UUID of the repository.
    /// </summary>
    public static string? RepositoryUuid => Environment.GetEnvironmentVariable("BITBUCKET_REPO_UUID");

    /// <summary>
    ///     The full name of the repository (everything that comes after http://bitbucket.org/).
    /// </summary>
    public static string? RepositoryFullName => Environment.GetEnvironmentVariable("BITBUCKET_REPO_FULL_NAME");

    /// <summary>
    ///     The source branch. This value is only available on branches. Not available for builds against tags, or custom
    ///     pipelines.
    /// </summary>
    public static string? Branch => Environment.GetEnvironmentVariable("BITBUCKET_BRANCH");

    /// <summary>
    ///     The tag of a commit that kicked off the build. This value is only available on tags. Not available for builds
    ///     against branches.
    /// </summary>
    public static string? Tag => Environment.GetEnvironmentVariable("BITBUCKET_TAG");

    /// <summary>
    ///     For use with Mercurial projects.
    /// </summary>
    public static string? Bookmark => Environment.GetEnvironmentVariable("BITBUCKET_BOOKMARK");

    /// <summary>
    ///     Zero-based index of the current step in the group, for example: 0, 1, 2, … Not available outside a parallel step.
    /// </summary>
    public static int? ParallelStep => Environment.GetEnvironmentVariable("BITBUCKET_PARALLEL_STEP")?.Let(int.Parse);

    /// <summary>
    ///     Total number of steps in the group, for example: 5. Not available outside a parallel step.
    /// </summary>
    public static int? ParallelStepCount =>
        Environment.GetEnvironmentVariable("BITBUCKET_PARALLEL_STEP_COUNT")?.Let(int.Parse);

    /// <summary>
    ///     The pull request ID. Only available on a pull request triggered build.
    /// </summary>
    public static int? PullRequestId => Environment.GetEnvironmentVariable("BITBUCKET_PR_ID")?.Let(int.Parse);

    /// <summary>
    ///     The pull request destination branch (used in combination with BITBUCKET_BRANCH). Only available on a pull request
    ///     triggered build.
    /// </summary>
    public static string? PullRequestDestinationBranch =>
        Environment.GetEnvironmentVariable("BITBUCKET_PR_DESTINATION_BRANCH");

    /// <summary>
    ///     The URL for the origin, for example: http://bitbucket.org/&lt;account&gt;/&lt;repo&gt;
    /// </summary>
    public static string? GitHttpOrigin => Environment.GetEnvironmentVariable("BITBUCKET_GIT_HTTP_ORIGIN");

    /// <summary>
    ///     Your SSH origin, for example: git@bitbucket.org:/&lt;account&gt;/&lt;repo&gt;.git
    /// </summary>
    public static string? GitSshOrigin => Environment.GetEnvironmentVariable("BITBUCKET_GIT_SSH_ORIGIN");

    /// <summary>
    ///     The exit code of a step, can be used in after-script sections. Values can be 0 (success) or 1 (failed)
    /// </summary>
    public static string? ExitCode => Environment.GetEnvironmentVariable("BITBUCKET_EXIT_CODE");

    /// <summary>
    ///     The UUID of the step.
    /// </summary>
    public static string? StepUuid => Environment.GetEnvironmentVariable("BITBUCKET_STEP_UUID");

    /// <summary>
    ///     The UUID of the pipeline.
    /// </summary>
    public static string? PipelineUuid => Environment.GetEnvironmentVariable("BITBUCKET_PIPELINE_UUID");

    /// <summary>
    ///     The URL friendly version of the environment name.
    /// </summary>
    public static string? DeploymentEnvironment =>
        Environment.GetEnvironmentVariable("BITBUCKET_DEPLOYMENT_ENVIRONMENT");

    /// <summary>
    ///     The UUID of the environment to access environments via the REST API.
    /// </summary>
    public static string? DeploymentEnvironmentUuid =>
        Environment.GetEnvironmentVariable("BITBUCKET_DEPLOYMENT_ENVIRONMENT_UUID");

    /// <summary>
    ///     The key of the project the current pipeline belongs to.
    /// </summary>
    public static string? ProjectKey => Environment.GetEnvironmentVariable("BITBUCKET_PROJECT_KEY");

    /// <summary>
    ///     The UUID of the project the current pipeline belongs to.
    /// </summary>
    public static string? ProjectUuid => Environment.GetEnvironmentVariable("BITBUCKET_PROJECT_UUID");

    /// <summary>
    ///     The person who kicked off the build ( by doing a push, merge etc), and for scheduled builds, the uuid of the
    ///     pipelines user.
    /// </summary>
    public static string? StepTriggererUuid => Environment.GetEnvironmentVariable("BITBUCKET_STEP_TRIGGERER_UUID");

    /// <summary>
    ///     The 'ID Token' generated by the Bitbucket OIDC provider that identifies the step. This token can be used to access
    ///     resource servers, such as AWS and GCP without using credentials.
    /// </summary>
    public static string? StepOidcToken => Environment.GetEnvironmentVariable("BITBUCKET_STEP_OIDC_TOKEN");
}