// Acquired originally from the NUKE Build project.
// Redistributed under the MIT License.
//
// Original Boilerplate:
// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace TacticalNuke.Bamboo;

/// <summary>
///     Interface according to the
///     <a href="https://confluence.atlassian.com/bamboo/bamboo-variables-289277087.html">official website</a>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static class BambooEnvironment
{
    public static long? AgentId => Environment.GetEnvironmentVariable("bamboo_agentId")?.Let(long.Parse);
    public static string? AgentWorkingDirectory => Environment.GetEnvironmentVariable("bamboo_agentWorkingDirectory");
    public static string? AgentHome => Environment.GetEnvironmentVariable("BAMBOO_AGENT_HOME");
    public static string? BuildKey => Environment.GetEnvironmentVariable("bamboo_buildKey");
    public static long? BuildNumber => Environment.GetEnvironmentVariable("bamboo_buildNumber")?.Let(long.Parse);
    public static string? BuildPlanName => Environment.GetEnvironmentVariable("bamboo_buildPlanName");
    public static string? BuildResultsKey => Environment.GetEnvironmentVariable("bamboo_buildResultKey");
    public static string? BuildResultsUrl => Environment.GetEnvironmentVariable("bamboo_buildResultsUrl");

    public static DateTime? BuildTimeStamp =>
        Environment.GetEnvironmentVariable("bamboo_buildTimeStamp")?.Let(DateTime.Parse);

    public static string? BuildWorkingDirectory => Environment.GetEnvironmentVariable("bamboo_build_working_directory");
    public static bool? BuildFailed => Environment.GetEnvironmentVariable("bamboo_buildFailed")?.Let(bool.Parse);
    public static string? PlanKey => Environment.GetEnvironmentVariable("bamboo_planKey");
    public static string? ShortPlanKey => Environment.GetEnvironmentVariable("bamboo_shortPlanKey");
    public static string? PlanName => Environment.GetEnvironmentVariable("bamboo_planName");
    public static string? ShortPlanName => Environment.GetEnvironmentVariable("bamboo_shortPlanName");
    public static string? PlanStorageTag => Environment.GetEnvironmentVariable("bamboo_plan_storageTag");
    public static string? PlanResultsUrl => Environment.GetEnvironmentVariable("bamboo_resultsUrl");
    public static string? ShortJobKey => Environment.GetEnvironmentVariable("bamboo_shortJobKey");
    public static string? ShortJobName => Environment.GetEnvironmentVariable("bamboo_shortJobName");
}