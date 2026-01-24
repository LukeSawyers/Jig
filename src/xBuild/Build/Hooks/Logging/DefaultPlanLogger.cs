using xBuild.Logging;

namespace xBuild.Build.Hooks.Logging;

/// <summary>
/// Default build plan printer that exclusively uses <see cref="IBuildLogger"/>
/// </summary>
/// <param name="logger"></param>
/// <param name="buildContext"></param>
public class DefaultPlanLogger(
    IBuildLogger logger,
    IBuildContext buildContext,
    DefaultLoggingHooksOptionsProvider optionsProvider
) : IBuildInitializedHandler
{
    public async ValueTask OnBuildInitialized()
    {
        if (optionsProvider.NoPlan)
        {
            return;
        }

        var triggeredTargetNames = buildContext.TargetResults.Keys.Select(t => t.Name).ToArray();

        logger.LogInformationFormat("Invoking:");

        foreach (var invokedTarget in triggeredTargetNames)
        {
            var template = triggeredTargetNames.Contains(invokedTarget)
                ? $" - {invokedTarget}"
                : $" - {invokedTarget} *";

            logger.LogInformationFormat(template);
        }
    }
}