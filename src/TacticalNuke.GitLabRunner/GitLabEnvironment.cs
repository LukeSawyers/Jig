// Acquired originally from the NUKE Build project.
// Redistributed under the MIT License.
//
// Original Boilerplate:
// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using JetBrains.Annotations;

namespace TacticalNuke.GitLabRunner;

/// <summary>
///     Interface according to the <a href="https://docs.gitlab.com/ce/ci/variables/README.html">official website</a>.
/// </summary>
[PublicAPI]
public static class GitLabEnvironment
{
    public static bool IsRunningGitLab => Environment.GetEnvironmentVariable("GITLAB_CI") != null;

    /// <summary>
    ///     Available for all jobs executed in CI/CD. <c>true</c> when available.
    /// </summary>
    public static bool Ci => Environment.GetEnvironmentVariable("CI")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The branch or tag name for which project is built.
    /// </summary>
    public static string? CommitRefName => Environment.GetEnvironmentVariable("CI_COMMIT_REF_NAME");

    /// <summary>
    ///     <c>$CI_COMMIT_REF_NAME</c> lowercased, shortened to 63 bytes, and with everything except <c>0-9</c> and <c>a-z</c>
    ///     replaced with <c>-</c>.
    ///     No leading / trailing <c>-</c>.
    ///     Use in URLs, host names and domain names.
    /// </summary>
    public static string? CommitRefSlug => Environment.GetEnvironmentVariable("CI_COMMIT_REF_SLUG");

    /// <summary>
    ///     The commit revision for which project is built.
    /// </summary>
    public static string? CommitSha => Environment.GetEnvironmentVariable("CI_COMMIT_SHA");

    /// <summary>
    ///     The commit tag name.
    ///     Available only in pipelines for tags.
    /// </summary>
    public static string? CommitTag => Environment.GetEnvironmentVariable("CI_COMMIT_TAG");

    /// <summary>
    ///     The path to the CI/CD configuration file.
    ///     Defaults to <c>.gitlab-ci.yml</c>.
    ///     Read-only inside a running pipeline.
    /// </summary>
    public static string? ConfigPath => Environment.GetEnvironmentVariable("CI_CONFIG_PATH");

    /// <summary>
    ///     Only available if the job is executed in a disposable environment (something that is created only for this job and
    ///     disposed of/destroyed after the execution - all executors except <c>shell</c> and <c>ssh</c>).
    ///     <c>true</c> when available.
    /// </summary>
    public static bool DisposableEnvironment =>
        Environment.GetEnvironmentVariable("CI_DISPOSABLE_ENVIRONMENT")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The internal ID of the job, unique across all jobs in the GitLab instance.
    /// </summary>
    public static long? JobId => Environment.GetEnvironmentVariable("CI_JOB_ID")?.Let(long.Parse);

    /// <summary>
    ///     Only available if the job was started manually.
    ///     <c>true</c> when available.
    /// </summary>
    public static bool JobManual => Environment.GetEnvironmentVariable("CI_JOB_MANUAL")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The name of the job as defined in <c>.gitlab-ci.yml</c>.
    /// </summary>
    public static string? JobName => Environment.GetEnvironmentVariable("CI_JOB_NAME");

    /// <summary>
    ///     The name of the stage as defined in <c>.gitlab-ci.yml</c>.
    /// </summary>
    public static string? JobStage => Environment.GetEnvironmentVariable("CI_JOB_STAGE");

    /// <summary>
    ///     A token to authenticate with certain API endpoints.
    ///     The token is valid as long as the job is running.
    /// </summary>
    public static string? JobToken => Environment.GetEnvironmentVariable("CI_JOB_TOKEN");

    /// <summary>
    ///     The full path to Git clone (HTTP) the repository with a CI/CD job token, in the format
    ///     <c>https://gitlab-ci-token:$CI_JOB_TOKEN@gitlab.example.com/my-group/my-project.git</c>.
    /// </summary>
    public static string? RepositoryUrl => Environment.GetEnvironmentVariable("CI_REPOSITORY_URL");

    /// <summary>
    ///     The description of the runner.
    /// </summary>
    public static string? RunnerDescription => Environment.GetEnvironmentVariable("CI_RUNNER_DESCRIPTION");

    /// <summary>
    ///     The unique ID of the runner being used.
    /// </summary>
    public static long? RunnerId => Environment.GetEnvironmentVariable("CI_RUNNER_ID")?.Let(long.Parse);

    /// <summary>
    ///     A comma-separated list of the runner tags.
    /// </summary>
    public static string? RunnerTags => Environment.GetEnvironmentVariable("CI_RUNNER_TAGS");

    /// <summary>
    ///     The instance-level ID of the current pipeline.
    ///     This ID is unique across all projects on the GitLab instance.
    /// </summary>
    public static long? PipelineId => Environment.GetEnvironmentVariable("CI_PIPELINE_ID")?.Let(long.Parse);

    /// <summary>
    ///     The flag to indicate that job was <a href="https://docs.gitlab.com/ce/ci/triggers/README.html">triggered</a>.
    /// </summary>
    public static bool PipelineTriggered =>
        Environment.GetEnvironmentVariable("CI_PIPELINE_TRIGGERED")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     How the pipeline was triggered.
    ///     Can be <c>push</c>, <c>web</c>, <c>schedule</c>, <c>api</c>, <c>external</c>, <c>chat</c>, <c>webide</c>,
    ///     <c>merge_request_event</c>, <c>external_pull_request_event</c>, <c>parent_pipeline</c>, <c>trigger</c>, or
    ///     <c>pipeline</c>.
    ///     For a description of each value, see
    ///     <a href="https://docs.gitlab.com/ee/ci/jobs/job_control.html#common-if-clauses-for-rules">
    ///         Common if clauses for
    ///         rules
    ///     </a>
    ///     , which uses this variable to control when jobs run.
    /// </summary>
    public static string? PipelineSource => Environment.GetEnvironmentVariable("CI_PIPELINE_SOURCE");

    /// <summary>
    ///     The full path where the repository is cloned and where the job is run.
    /// </summary>
    public static string? ProjectDirectory => Environment.GetEnvironmentVariable("CI_PROJECT_DIR");

    /// <summary>
    ///     The ID of the current project.
    ///     This ID is unique across all projects on the GitLab instance.
    /// </summary>
    public static long? ProjectId => Environment.GetEnvironmentVariable("CI_PROJECT_ID")?.Let(long.Parse);

    /// <summary>
    ///     The name of the directory for the project.
    ///     For example if the project URL is <c>gitlab.example.com/group-name/project-1</c>, <c>$CI_PROJECT_NAME</c> is
    ///     <c>project-1</c>.
    /// </summary>
    public static string? ProjectName => Environment.GetEnvironmentVariable("CI_PROJECT_NAME");

    /// <summary>
    ///     The project namespace (username or group name) of the job.
    /// </summary>
    public static string? ProjectNamespace => Environment.GetEnvironmentVariable("CI_PROJECT_NAMESPACE");

    /// <summary>
    ///     The project namespace with the project name included.
    /// </summary>
    public static string? ProjectPath => Environment.GetEnvironmentVariable("CI_PROJECT_PATH");

    /// <summary>
    ///     <c>$CI_PROJECT_PATH</c> in lowercase with characters that are not <c>a-z</c> or <c>0-9</c> replaced with <c>-</c>
    ///     and shortened to 63 bytes.
    ///     Use in URLs and domain names.
    /// </summary>
    public static string? ProjectPathSlug => Environment.GetEnvironmentVariable("CI_PROJECT_PATH_SLUG");

    /// <summary>
    ///     The HTTP(S) address of the project.
    /// </summary>
    public static string? ProjectUrl => Environment.GetEnvironmentVariable("CI_PROJECT_URL");

    /// <summary>
    ///     The project visibility.
    ///     Can be <c>internal</c>, <c>private</c>, or <c>public</c>.
    /// </summary>
    public static GitLabProjectVisibility? ProjectVisibility => Environment
        .GetEnvironmentVariable("CI_PROJECT_VISIBILITY")?.Let(Enum.Parse<GitLabProjectVisibility>);

    /// <summary>
    ///     Address of the container registry server, formatted as <c>&lt;host&gt;[:&lt;port&gt;]</c>.
    ///     For example: <c>registry.gitlab.example.com</c>.
    ///     Only available if the container registry is enabled for the GitLab instance.
    /// </summary>
    public static string? Registry => Environment.GetEnvironmentVariable("CI_REGISTRY");

    /// <summary>
    ///     Base address for the container registry to push, pull, or tag project's images, formatted as
    ///     <c>&lt;host&gt;[:&lt;port&gt;]/&lt;project_full_path&gt;</c>.
    ///     For example: <c>registry.gitlab.example.com/my_group/my_project</c>.
    ///     Image names must follow the container registry naming convention.
    ///     Only available if the container registry is enabled for the project.
    /// </summary>
    public static string? RegistryImage => Environment.GetEnvironmentVariable("CI_REGISTRY_IMAGE");

    /// <summary>
    ///     The password to push containers to the GitLab project's container registry.
    ///     Only available if the container registry is enabled for the project.
    ///     This password value is the same as the <c>$CI_JOB_TOKEN</c> and is valid only as long as the job is running.
    ///     Use the <c>$CI_DEPLOY_PASSWORD</c> for long-lived access to the registry
    /// </summary>
    public static string? RegistryPassword => Environment.GetEnvironmentVariable("CI_REGISTRY_PASSWORD");

    /// <summary>
    ///     The username to push containers to the project's GitLab container registry.
    ///     Only available if the container registry is enabled for the project.
    /// </summary>
    public static string? RegistryUser => Environment.GetEnvironmentVariable("CI_REGISTRY_USER");

    /// <summary>
    ///     The name of CI/CD server that coordinates jobs.
    /// </summary>
    public static string? ServerName => Environment.GetEnvironmentVariable("CI_SERVER_NAME");

    /// <summary>
    ///     GitLab revision that schedules jobs.
    /// </summary>
    public static string? ServerRevision => Environment.GetEnvironmentVariable("CI_SERVER_REVISION");

    /// <summary>
    ///     The full version of the GitLab instance.
    /// </summary>
    public static string? ServerVersion => Environment.GetEnvironmentVariable("CI_SERVER_VERSION");

    /// <summary>
    ///     The numeric ID of the user who started the pipeline, unless the job is a manual job.
    ///     In manual jobs, the value is the ID of the user who started the job.
    /// </summary>
    public static long? GitLabUserId => Environment.GetEnvironmentVariable("GITLAB_USER_ID")?.Let(long.Parse);

    /// <summary>
    ///     The email of the user who started the pipeline, unless the job is a manual job.
    ///     In manual jobs, the value is the email of the user who started the job.
    /// </summary>
    public static string? GitLabUserEmail => Environment.GetEnvironmentVariable("GITLAB_USER_EMAIL");

    /// <summary>
    ///     The username of the user who started the pipeline, unless the job is a manual job.
    ///     In manual jobs, the value is the username of the user who started the job.
    /// </summary>
    public static string? GitLabUserLogin => Environment.GetEnvironmentVariable("GITLAB_USER_LOGIN");

    /// <summary>
    ///     The real name of the user who started the job.
    /// </summary>
    public static string? GitLabUserName => Environment.GetEnvironmentVariable("GITLAB_USER_NAME");

    /// ---- ///
    /// <summary>
    ///     The Source chat channel that triggered the ChatOps command.
    /// </summary>
    public static string? ChatChannel => Environment.GetEnvironmentVariable("CHAT_CHANNEL");

    /// <summary>
    ///     The additional arguments passed with the ChatOps command.
    /// </summary>
    public static string? ChatInput => Environment.GetEnvironmentVariable("CHAT_INPUT");

    /// <summary>
    ///     The chat service's user ID of the user who triggered the ChatOps command.
    /// </summary>
    public static string? ChatUserId => Environment.GetEnvironmentVariable("CHAT_USER_ID");

    /// <summary>
    ///     The GitLab API v4 root URL.
    /// </summary>
    public static string? ApiV4Url => Environment.GetEnvironmentVariable("CI_API_V4_URL");

    /// <summary>
    ///     The GitLab API GraphQL root URL.
    /// </summary>
    public static string? ApiGraphqlUrl => Environment.GetEnvironmentVariable("CI_API_GRAPHQL_URL");

    /// <summary>
    ///     The top-level directory where builds are executed.
    /// </summary>
    public static string? BuildsDir => Environment.GetEnvironmentVariable("CI_BUILDS_DIR");

    /// <summary>
    ///     The author of the commit in <c>Name &lt;email&gt;</c> format.
    /// </summary>
    public static string? CommitAuthor => Environment.GetEnvironmentVariable("CI_COMMIT_AUTHOR");

    /// <summary>
    ///     The previous latest commit present on a branch or tag.
    ///     Is always <c>0000000000000000000000000000000000000000</c> for merge request pipelines, the first commit in
    ///     pipelines for branches or tags, or when manually running a pipeline.
    /// </summary>
    public static string? CommitBeforeSha => Environment.GetEnvironmentVariable("CI_COMMIT_BEFORE_SHA");

    /// <summary>
    ///     The commit branch name.
    ///     Available in branch pipelines, including pipelines for the default branch.
    ///     Not available in merge request pipelines or tag pipelines.
    /// </summary>
    public static string? CommitBranch => Environment.GetEnvironmentVariable("CI_COMMIT_BRANCH");

    /// <summary>
    ///     The description of the commit.
    ///     If the title is shorter than 100 characters, the message without the first line.
    /// </summary>
    public static string? CommitDescription => Environment.GetEnvironmentVariable("CI_COMMIT_DESCRIPTION");

    /// <summary>
    ///     The full commit message.
    /// </summary>
    public static string? CommitMessage => Environment.GetEnvironmentVariable("CI_COMMIT_MESSAGE");

    /// <summary>
    ///     <c>true</c> if the job is running for a protected reference, <c>false</c> otherwise.
    /// </summary>
    public static bool CommitRefProtected =>
        Environment.GetEnvironmentVariable("CI_COMMIT_REF_PROTECTED")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The first eight characters of <c>$CI_COMMIT_SHA</c>.
    /// </summary>
    public static string? CommitShortSha => Environment.GetEnvironmentVariable("CI_COMMIT_SHORT_SHA");

    /// <summary>
    ///     The commit tag message.
    ///     Available only in pipelines for tags.
    /// </summary>
    public static string? CommitTagMessage => Environment.GetEnvironmentVariable("CI_COMMIT_TAG_MESSAGE");

    /// <summary>
    ///     The timestamp of the commit in the ISO 8601 format.
    ///     For example, <c>2022-01-31T16:47:55Z</c>.
    ///     UTC by default.
    /// </summary>
    public static string? CommitTimestamp => Environment.GetEnvironmentVariable("CI_COMMIT_TIMESTAMP");

    /// <summary>
    ///     The title of the commit.
    ///     The full first line of the message.
    /// </summary>
    public static string? CommitTitle => Environment.GetEnvironmentVariable("CI_COMMIT_TITLE");

    /// <summary>
    ///     The unique ID of build execution in a single executor.
    /// </summary>
    public static string? ConcurrentId => Environment.GetEnvironmentVariable("CI_CONCURRENT_ID");

    /// <summary>
    ///     The unique ID of build execution in a single executor and project.
    /// </summary>
    public static string? ConcurrentProjectId => Environment.GetEnvironmentVariable("CI_CONCURRENT_PROJECT_ID");

    /// <summary>
    ///     <c>true</c> if debug logging (tracing) is enabled.
    /// </summary>
    public static bool DebugTrace => Environment.GetEnvironmentVariable("CI_DEBUG_TRACE")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     <c>true</c> if service container logging is enabled.
    /// </summary>
    public static bool DebugServices =>
        Environment.GetEnvironmentVariable("CI_DEBUG_SERVICES")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The name of the project's default branch.
    /// </summary>
    public static string? DefaultBranch => Environment.GetEnvironmentVariable("CI_DEFAULT_BRANCH");

    /// <summary>
    ///     The direct group image prefix for pulling images through the Dependency Proxy.
    /// </summary>
    public static string? DependencyProxyDirectGroupImagePrefix =>
        Environment.GetEnvironmentVariable("CI_DEPENDENCY_PROXY_DIRECT_GROUP_IMAGE_PREFIX");

    /// <summary>
    ///     The top-level group image prefix for pulling images through the Dependency Proxy.
    /// </summary>
    public static string? DependencyProxyGroupImagePrefix =>
        Environment.GetEnvironmentVariable("CI_DEPENDENCY_PROXY_GROUP_IMAGE_PREFIX");

    /// <summary>
    ///     The password to pull images through the Dependency Proxy.
    /// </summary>
    public static string? DependencyProxyPassword => Environment.GetEnvironmentVariable("CI_DEPENDENCY_PROXY_PASSWORD");

    /// <summary>
    ///     The server for logging in to the Dependency Proxy.
    ///     This is equivalent to <c>$CI_SERVER_HOST:$CI_SERVER_PORT</c>.
    /// </summary>
    public static string? DependencyProxyServer => Environment.GetEnvironmentVariable("CI_DEPENDENCY_PROXY_SERVER");

    /// <summary>
    ///     The username to pull images through the Dependency Proxy.
    /// </summary>
    public static string? DependencyProxyUser => Environment.GetEnvironmentVariable("CI_DEPENDENCY_PROXY_USER");

    /// <summary>
    ///     Only available if the pipeline runs during a deploy freeze window.
    ///     <c>true</c> when available.
    /// </summary>
    public static bool DeployFreeze =>
        Environment.GetEnvironmentVariable("CI_DEPLOY_FREEZE")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The authentication password of the GitLab Deploy Token, if the project has one.
    /// </summary>
    public static string? DeployPassword => Environment.GetEnvironmentVariable("CI_DEPLOY_PASSWORD");

    /// <summary>
    ///     The authentication username of the GitLab Deploy Token, if the project has one.
    /// </summary>
    public static string? DeployUser => Environment.GetEnvironmentVariable("CI_DEPLOY_USER");

    /// <summary>
    ///     The name of the environment for this job.
    ///     Available if <c>environment:name</c> is set.
    /// </summary>
    public static string? EnvironmentName => Environment.GetEnvironmentVariable("CI_ENVIRONMENT_NAME");

    /// <summary>
    ///     The simplified version of the environment name, suitable for inclusion in DNS, URLs, Kubernetes labels, and so on.
    ///     Available if <c>environment:name</c> is set.
    ///     The slug is truncated to 24 characters.
    ///     A random suffix is automatically added to uppercase environment names.
    /// </summary>
    public static string? EnvironmentSlug => Environment.GetEnvironmentVariable("CI_ENVIRONMENT_SLUG");

    /// <summary>
    ///     The URL of the environment for this job.
    ///     Available if <c>environment:url</c> is set.
    /// </summary>
    public static string? EnvironmentUrl => Environment.GetEnvironmentVariable("CI_ENVIRONMENT_URL");

    /// <summary>
    ///     The action annotation specified for this job's environment.
    ///     Available if <c>environment:action</c> is set.
    ///     Can be <c>start</c>, <c>prepare</c>, or <c>stop</c>.
    /// </summary>
    public static string? EnvironmentAction => Environment.GetEnvironmentVariable("CI_ENVIRONMENT_ACTION");

    /// <summary>
    ///     The deployment tier of the environment for this job.
    /// </summary>
    public static string? EnvironmentTier => Environment.GetEnvironmentVariable("CI_ENVIRONMENT_TIER");

    /// <summary>
    ///     The description of the release.
    ///     Available only on pipelines for tags.
    ///     Description length is limited to first 1024 characters.
    /// </summary>
    public static string? ReleaseDescription => Environment.GetEnvironmentVariable("CI_RELEASE_DESCRIPTION");

    /// <summary>
    ///     Only available if FIPS mode is enabled in the GitLab instance.
    ///     <c>true</c> when available.
    /// </summary>
    public static bool GitLabFipsMode =>
        Environment.GetEnvironmentVariable("CI_GITLAB_FIPS_MODE")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     Only available if the pipeline's project has an open requirement.
    ///     <c>true</c> when available.
    /// </summary>
    public static bool HasOpenRequirements =>
        Environment.GetEnvironmentVariable("CI_HAS_OPEN_REQUIREMENTS")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The name of the Docker image running the job.
    /// </summary>
    public static string? JobImage => Environment.GetEnvironmentVariable("CI_JOB_IMAGE");

    /// <summary>
    ///     A RS256 JSON web token to authenticate with third party systems that support JWT authentication, for example
    ///     HashiCorp's Vault.
    ///     <a href="https://docs.gitlab.com/ee/update/deprecations.html#old-versions-of-json-web-tokens-are-deprecated">
    ///         Deprecated
    ///         in GitLab 15.9
    ///     </a>
    ///     and scheduled to be removed in GitLab 17.0.
    ///     Use ID tokens instead.
    /// </summary>
    [Obsolete]
    public static string? JobJwt => Environment.GetEnvironmentVariable("CI_JOB_JWT");

    /// <summary>
    ///     The same value as <c>$CI_JOB_JWT</c>.
    ///     <a href="https://docs.gitlab.com/ee/update/deprecations.html#old-versions-of-json-web-tokens-are-deprecated">
    ///         Deprecated
    ///         in GitLab 15.9
    ///     </a>
    ///     and scheduled to be removed in GitLab 17.0.
    ///     Use ID tokens instead.
    /// </summary>
    [Obsolete]
    public static string? JobJwtV1 => Environment.GetEnvironmentVariable("CI_JOB_JWT_V1");

    /// <summary>
    ///     A newly formatted RS256 JSON web token to increase compatibility.
    ///     Similar to <c>$CI_JOB_JWT</c>, except the issuer (<c>iss</c>) claim is changed from <c>gitlab.com</c> to
    ///     <c>https://gitlab.com</c>, <c>sub</c> has changed from <c>job_id</c> to a string that contains the project path,
    ///     and an <c>aud</c> claim is added.
    ///     The <c>aud</c> field is a constant value.
    ///     Trusting JWTs in multiple relying parties can lead to one RP sending a JWT to another one and acting maliciously as
    ///     a job.
    ///     <a href="https://docs.gitlab.com/ee/update/deprecations.html#old-versions-of-json-web-tokens-are-deprecated">
    ///         Deprecated
    ///         in GitLab 15.9
    ///     </a>
    ///     and scheduled to be removed in GitLab 17.0.
    ///     Use ID tokens instead.
    /// </summary>
    [Obsolete]
    public static string? JobJwtV2 => Environment.GetEnvironmentVariable("CI_JOB_JWT_V2");

    /// <summary>
    ///     <c>$CI_JOB_NAME</c> in lowercase, shortened to 63 bytes, and with everything except <c>0-9</c> and <c>a-z</c>
    ///     replaced with <c>-</c>.
    ///     No leading / trailing <c>-</c>.
    ///     Use in paths.
    /// </summary>
    public static string? JobNameSlug => Environment.GetEnvironmentVariable("CI_JOB_NAME_SLUG");

    /// <summary>
    ///     The status of the job as each runner stage is executed.
    ///     Use with <c>after_script</c>.
    ///     Can be <c>success</c>, <c>failed</c>, or <c>canceled</c>.
    /// </summary>
    public static string? JobStatus => Environment.GetEnvironmentVariable("CI_JOB_STATUS");

    /// <summary>
    ///     The job timeout, in seconds.
    /// </summary>
    public static string? JobTimeout => Environment.GetEnvironmentVariable("CI_JOB_TIMEOUT");

    /// <summary>
    ///     The job details URL.
    /// </summary>
    public static string? JobUrl => Environment.GetEnvironmentVariable("CI_JOB_URL");

    /// <summary>
    ///     The date and time when a job started, in ISO 8601 format.
    ///     For example, <c>2022-01-31T16:47:55Z</c>.
    ///     UTC by default.
    /// </summary>
    public static string? JobStartedAt => Environment.GetEnvironmentVariable("CI_JOB_STARTED_AT");

    /// <summary>
    ///     Only available if the pipeline has a Kubernetes cluster available for deployments.
    ///     <c>true</c> when available.
    /// </summary>
    public static bool KubernetesActive =>
        Environment.GetEnvironmentVariable("CI_KUBERNETES_ACTIVE")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The index of the job in the job set.
    ///     Only available if the job uses <c>parallel</c>.
    /// </summary>
    public static string? NodeIndex => Environment.GetEnvironmentVariable("CI_NODE_INDEX");

    /// <summary>
    ///     The total number of instances of this job running in parallel.
    ///     Set to <c>1</c> if the job does not use <c>parallel</c>.
    /// </summary>
    public static string? NodeTotal => Environment.GetEnvironmentVariable("CI_NODE_TOTAL");

    /// <summary>
    ///     A comma-separated list of up to four merge requests that use the current branch and project as the merge request
    ///     source.
    ///     Only available in branch and merge request pipelines if the branch has an associated merge request.
    ///     For example, <c>gitlab-org/gitlab!333,gitlab-org/gitlab-foss!11</c>.
    /// </summary>
    public static string? OpenMergeRequests => Environment.GetEnvironmentVariable("CI_OPEN_MERGE_REQUESTS");

    /// <summary>
    ///     The configured domain that hosts GitLab Pages.
    /// </summary>
    public static string? PagesDomain => Environment.GetEnvironmentVariable("CI_PAGES_DOMAIN");

    /// <summary>
    ///     The URL for a GitLab Pages site.
    ///     Always a subdomain of <c>$CI_PAGES_DOMAIN</c>.
    /// </summary>
    public static string? PagesUrl => Environment.GetEnvironmentVariable("CI_PAGES_URL");

    /// <summary>
    ///     The project-level IID (internal ID) of the current pipeline.
    ///     This ID is unique only within the current project.
    /// </summary>
    public static string? PipelineIid => Environment.GetEnvironmentVariable("CI_PIPELINE_IID");

    /// <summary>
    ///     The URL for the pipeline details.
    /// </summary>
    public static string? PipelineUrl => Environment.GetEnvironmentVariable("CI_PIPELINE_URL");

    /// <summary>
    ///     The date and time when the pipeline was created, in ISO 8601 format.
    ///     For example, <c>2022-01-31T16:47:55Z</c>.
    ///     UTC by default.
    /// </summary>
    public static string? PipelineCreatedAt => Environment.GetEnvironmentVariable("CI_PIPELINE_CREATED_AT");

    /// <summary>
    ///     The pipeline name defined in <c>workflow:name</c>
    /// </summary>
    public static string? PipelineName => Environment.GetEnvironmentVariable("CI_PIPELINE_NAME");

    /// <summary>
    ///     The full path the repository is cloned to, and where the job runs from.
    ///     If the GitLab Runner <c>builds_dir</c> parameter is set, this variable is set relative to the value of
    ///     <c>builds_dir</c>.
    ///     For more information, see the Advanced GitLab Runner configuration.
    /// </summary>
    public static string? ProjectDir => Environment.GetEnvironmentVariable("CI_PROJECT_DIR");

    /// <summary>
    ///     The project namespace ID of the job.
    /// </summary>
    public static string? ProjectNamespaceId => Environment.GetEnvironmentVariable("CI_PROJECT_NAMESPACE_ID");

    /// <summary>
    ///     A comma-separated, lowercase list of the languages used in the repository.
    ///     For example <c>ruby,javascript,html,css</c>.
    ///     The maximum number of languages is limited to 5.
    ///     An issue proposes to increase the limit.
    /// </summary>
    public static string? ProjectRepositoryLanguages =>
        Environment.GetEnvironmentVariable("CI_PROJECT_REPOSITORY_LANGUAGES");

    /// <summary>
    ///     The root project namespace (username or group name) of the job.
    ///     For example, if <c>$CI_PROJECT_NAMESPACE</c> is <c>root-group/child-group/grandchild-group</c>,
    ///     <c>$CI_PROJECT_ROOT_NAMESPACE</c> is <c>root-group</c>.
    /// </summary>
    public static string? ProjectRootNamespace => Environment.GetEnvironmentVariable("CI_PROJECT_ROOT_NAMESPACE");

    /// <summary>
    ///     The human-readable project name as displayed in the GitLab web interface.
    /// </summary>
    public static string? ProjectTitle => Environment.GetEnvironmentVariable("CI_PROJECT_TITLE");

    /// <summary>
    ///     The project description as displayed in the GitLab web interface.
    /// </summary>
    public static string? ProjectDescription => Environment.GetEnvironmentVariable("CI_PROJECT_DESCRIPTION");

    /// <summary>
    ///     The project external authorization classification label.
    /// </summary>
    public static string? ProjectClassificationLabel =>
        Environment.GetEnvironmentVariable("CI_PROJECT_CLASSIFICATION_LABEL");

    /// <summary>
    ///     The OS/architecture of the GitLab Runner executable.
    ///     Might not be the same as the environment of the executor.
    /// </summary>
    public static string? RunnerExecutableArch => Environment.GetEnvironmentVariable("CI_RUNNER_EXECUTABLE_ARCH");

    /// <summary>
    ///     The revision of the runner running the job.
    /// </summary>
    public static string? RunnerRevision => Environment.GetEnvironmentVariable("CI_RUNNER_REVISION");

    /// <summary>
    ///     The runner's unique ID, used to authenticate new job requests.
    ///     In <a href="https://gitlab.com/gitlab-org/security/gitlab/-/merge_requests/2251">GitLab 14.9</a> and later, the
    ///     token contains a prefix, and the first 17 characters are used.
    ///     Prior to 14.9, the first eight characters are used.
    /// </summary>
    public static string? RunnerShortToken => Environment.GetEnvironmentVariable("CI_RUNNER_SHORT_TOKEN");

    /// <summary>
    ///     The version of the GitLab Runner running the job.
    /// </summary>
    public static string? RunnerVersion => Environment.GetEnvironmentVariable("CI_RUNNER_VERSION");

    /// <summary>
    ///     The host of the GitLab instance URL, without protocol or port.
    ///     For example <c>gitlab.example.com</c>.
    /// </summary>
    public static string? ServerHost => Environment.GetEnvironmentVariable("CI_SERVER_HOST");

    /// <summary>
    ///     The port of the GitLab instance URL, without host or protocol.
    ///     For example <c>8080</c>.
    /// </summary>
    public static string? ServerPort => Environment.GetEnvironmentVariable("CI_SERVER_PORT");

    /// <summary>
    ///     The protocol of the GitLab instance URL, without host or port.
    ///     For example <c>https</c>.
    /// </summary>
    public static string? ServerProtocol => Environment.GetEnvironmentVariable("CI_SERVER_PROTOCOL");

    /// <summary>
    ///     The SSH host of the GitLab instance, used for access to Git repositories via SSH.
    ///     For example <c>gitlab.com</c>.
    /// </summary>
    public static string? ServerShellSshHost => Environment.GetEnvironmentVariable("CI_SERVER_SHELL_SSH_HOST");

    /// <summary>
    ///     The SSH port of the GitLab instance, used for access to Git repositories via SSH.
    ///     For example <c>22</c>.
    /// </summary>
    public static string? ServerShellSshPort => Environment.GetEnvironmentVariable("CI_SERVER_SHELL_SSH_PORT");

    /// <summary>
    ///     File containing the TLS CA certificate to verify the GitLab server when <c>tls-ca-file</c> set in runner settings.
    /// </summary>
    public static string? ServerTlsCaFile => Environment.GetEnvironmentVariable("CI_SERVER_TLS_CA_FILE");

    /// <summary>
    ///     File containing the TLS certificate to verify the GitLab server when <c>tls-cert-file</c> set in runner settings.
    /// </summary>
    public static string? ServerTlsCertFile => Environment.GetEnvironmentVariable("CI_SERVER_TLS_CERT_FILE");

    /// <summary>
    ///     File containing the TLS key to verify the GitLab server when <c>tls-key-file</c> set in runner settings.
    /// </summary>
    public static string? ServerTlsKeyFile => Environment.GetEnvironmentVariable("CI_SERVER_TLS_KEY_FILE");

    /// <summary>
    ///     The base URL of the GitLab instance, including protocol and port.
    ///     For example <c>https://gitlab.example.com:8080</c>.
    /// </summary>
    public static string? ServerUrl => Environment.GetEnvironmentVariable("CI_SERVER_URL");

    /// <summary>
    ///     The major version of the GitLab instance.
    ///     For example, if the GitLab version is <c>13.6.1</c>, the <c>$CI_SERVER_VERSION_MAJOR</c> is <c>13</c>.
    /// </summary>
    public static string? ServerVersionMajor => Environment.GetEnvironmentVariable("CI_SERVER_VERSION_MAJOR");

    /// <summary>
    ///     The minor version of the GitLab instance.
    ///     For example, if the GitLab version is <c>13.6.1</c>, the <c>$CI_SERVER_VERSION_MINOR</c> is <c>6</c>.
    /// </summary>
    public static string? ServerVersionMinor => Environment.GetEnvironmentVariable("CI_SERVER_VERSION_MINOR");

    /// <summary>
    ///     The patch version of the GitLab instance.
    ///     For example, if the GitLab version is <c>13.6.1</c>, the <c>$CI_SERVER_VERSION_PATCH</c> is <c>1</c>.
    /// </summary>
    public static string? ServerVersionPatch => Environment.GetEnvironmentVariable("CI_SERVER_VERSION_PATCH");

    /// <summary>
    ///     Available for all jobs executed in CI/CD. <c>yes</c> when available.
    /// </summary>
    public static string? Server => Environment.GetEnvironmentVariable("CI_SERVER");

    /// <summary>
    ///     Only available if the job is executed in a shared environment (something that is persisted across CI/CD
    ///     invocations, like the <c>shell</c> or <c>ssh</c> executor).
    ///     <c>true</c> when available.
    /// </summary>
    public static bool SharedEnvironment =>
        Environment.GetEnvironmentVariable("CI_SHARED_ENVIRONMENT")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The host of the registry used by CI/CD templates.
    ///     Defaults to <c>registry.gitlab.com</c>.
    /// </summary>
    public static string? TemplateRegistryHost => Environment.GetEnvironmentVariable("CI_TEMPLATE_REGISTRY_HOST");

    /// <summary>
    ///     Available for all jobs executed in CI/CD. <c>true</c> when available.
    /// </summary>
    public static bool GitLabCi => Environment.GetEnvironmentVariable("GITLAB_CI")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The comma-separated list of licensed features available for the GitLab instance and license.
    /// </summary>
    public static string? GitLabFeatures => Environment.GetEnvironmentVariable("GITLAB_FEATURES");

    /// <summary>
    ///     The path to the <c>kubeconfig</c> file with contexts for every shared agent connection.
    ///     Only available when a GitLab agent is authorized to access the project.
    /// </summary>
    public static string? Kubeconfig => Environment.GetEnvironmentVariable("KUBECONFIG");

    /// <summary>
    ///     The webhook payload.
    ///     Only available when a pipeline is triggered with a webhook.
    /// </summary>
    public static string? TriggerPayload => Environment.GetEnvironmentVariable("TRIGGER_PAYLOAD");

    /// <summary>
    ///     Approval status of the merge request. <c>true</c> when merge request approvals is available and the merge request
    ///     has been approved.
    /// </summary>
    public static bool MergeRequestApproved =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_APPROVED")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     Comma-separated list of usernames of assignees for the merge request.
    /// </summary>
    public static string? MergeRequestAssignees => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_ASSIGNEES");

    /// <summary>
    ///     The base SHA of the merge request diff.
    /// </summary>
    public static string? MergeRequestDiffBaseSha =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_DIFF_BASE_SHA");

    /// <summary>
    ///     The version of the merge request diff.
    /// </summary>
    public static string? MergeRequestDiffId => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_DIFF_ID");

    /// <summary>
    ///     The event type of the merge request.
    ///     Can be <c>detached</c>, <c>merged_result</c> or <c>merge_train</c>.
    /// </summary>
    public static string? MergeRequestEventType => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_EVENT_TYPE");

    /// <summary>
    ///     The description of the merge request.
    ///     If the description is more than 2700 characters long, only the first 2700 characters are stored in the variable.
    /// </summary>
    public static string? MergeRequestDescription => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_DESCRIPTION");

    /// <summary>
    ///     <c>true</c> if <c>$CI_MERGE_REQUEST_DESCRIPTION</c> is truncated down to 2700 characters because the description of
    ///     the merge request is too long.
    /// </summary>
    public static bool MergeRequestDescriptionIsTruncated =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_DESCRIPTION_IS_TRUNCATED")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The instance-level ID of the merge request.
    ///     This is a unique ID across all projects on the GitLab instance.
    /// </summary>
    public static string? MergeRequestId => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_ID");

    /// <summary>
    ///     The project-level IID (internal ID) of the merge request.
    ///     This ID is unique for the current project, and is the number used in the merge request URL, page title, and other
    ///     visible locations.
    /// </summary>
    public static string? MergeRequestIid => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_IID");

    /// <summary>
    ///     Comma-separated label names of the merge request.
    /// </summary>
    public static string? MergeRequestLabels => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_LABELS");

    /// <summary>
    ///     The milestone title of the merge request.
    /// </summary>
    public static string? MergeRequestMilestone => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_MILESTONE");

    /// <summary>
    ///     The ID of the project of the merge request.
    /// </summary>
    public static string? MergeRequestProjectId => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_PROJECT_ID");

    /// <summary>
    ///     The path of the project of the merge request.
    ///     For example <c>namespace/awesome-project</c>.
    /// </summary>
    public static string? MergeRequestProjectPath =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_PROJECT_PATH");

    /// <summary>
    ///     The URL of the project of the merge request.
    ///     For example, <c>http://192.168.10.15:3000/namespace/awesome-project</c>.
    /// </summary>
    public static string? MergeRequestProjectUrl => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_PROJECT_URL");

    /// <summary>
    ///     The ref path of the merge request.
    ///     For example, <c>refs/merge-requests/1/head</c>.
    /// </summary>
    public static string? MergeRequestRefPath => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_REF_PATH");

    /// <summary>
    ///     The source branch name of the merge request.
    /// </summary>
    public static string? MergeRequestSourceBranchName =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_SOURCE_BRANCH_NAME");

    /// <summary>
    ///     <c>true</c> when the source branch of the merge request is protected.
    /// </summary>
    public static bool MergeRequestSourceBranchProtected =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_SOURCE_BRANCH_PROTECTED")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The HEAD SHA of the source branch of the merge request.
    ///     The variable is empty in merge request pipelines.
    ///     The SHA is present only in merged results pipelines.
    /// </summary>
    public static string? MergeRequestSourceBranchSha =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_SOURCE_BRANCH_SHA");

    /// <summary>
    ///     The ID of the source project of the merge request.
    /// </summary>
    public static string? MergeRequestSourceProjectId =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_SOURCE_PROJECT_ID");

    /// <summary>
    ///     The path of the source project of the merge request.
    /// </summary>
    public static string? MergeRequestSourceProjectPath =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_SOURCE_PROJECT_PATH");

    /// <summary>
    ///     The URL of the source project of the merge request.
    /// </summary>
    public static string? MergeRequestSourceProjectUrl =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_SOURCE_PROJECT_URL");

    /// <summary>
    ///     <c>true</c> when the squash on merge option is set.
    /// </summary>
    public static bool MergeRequestSquashOnMerge =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_SQUASH_ON_MERGE")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The target branch name of the merge request.
    /// </summary>
    public static string? MergeRequestTargetBranchName =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_TARGET_BRANCH_NAME");

    /// <summary>
    ///     <c>true</c> when the target branch of the merge request is protected.
    /// </summary>
    public static bool MergeRequestTargetBranchProtected =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_TARGET_BRANCH_PROTECTED")?.ToLowerInvariant() == "true";

    /// <summary>
    ///     The HEAD SHA of the target branch of the merge request.
    ///     The variable is empty in merge request pipelines.
    ///     The SHA is present only in merged results pipelines.
    /// </summary>
    public static string? MergeRequestTargetBranchSha =>
        Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_TARGET_BRANCH_SHA");

    /// <summary>
    ///     The title of the merge request.
    /// </summary>
    public static string? MergeRequestTitle => Environment.GetEnvironmentVariable("CI_MERGE_REQUEST_TITLE");

    /// <summary>
    ///     Pull request ID from GitHub.
    /// </summary>
    public static string? ExternalPullRequestIid => Environment.GetEnvironmentVariable("CI_EXTERNAL_PULL_REQUEST_IID");

    /// <summary>
    ///     The source repository name of the pull request.
    /// </summary>
    public static string? ExternalPullRequestSourceRepository =>
        Environment.GetEnvironmentVariable("CI_EXTERNAL_PULL_REQUEST_SOURCE_REPOSITORY");

    /// <summary>
    ///     The target repository name of the pull request.
    /// </summary>
    public static string? ExternalPullRequestTargetRepository =>
        Environment.GetEnvironmentVariable("CI_EXTERNAL_PULL_REQUEST_TARGET_REPOSITORY");

    /// <summary>
    ///     The source branch name of the pull request.
    /// </summary>
    public static string? ExternalPullRequestSourceBranchName =>
        Environment.GetEnvironmentVariable("CI_EXTERNAL_PULL_REQUEST_SOURCE_BRANCH_NAME");

    /// <summary>
    ///     The HEAD SHA of the source branch of the pull request.
    /// </summary>
    public static string? ExternalPullRequestSourceBranchSha =>
        Environment.GetEnvironmentVariable("CI_EXTERNAL_PULL_REQUEST_SOURCE_BRANCH_SHA");

    /// <summary>
    ///     The target branch name of the pull request.
    /// </summary>
    public static string? ExternalPullRequestTargetBranchName =>
        Environment.GetEnvironmentVariable("CI_EXTERNAL_PULL_REQUEST_TARGET_BRANCH_NAME");

    /// <summary>
    ///     The HEAD SHA of the target branch of the pull request.
    /// </summary>
    public static string? ExternalPullRequestTargetBranchSha =>
        Environment.GetEnvironmentVariable("CI_EXTERNAL_PULL_REQUEST_TARGET_BRANCH_SHA");
}