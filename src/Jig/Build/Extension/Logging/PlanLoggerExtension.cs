using Jig.Options;
using Microsoft.Extensions.Logging;

namespace Jig.Build.Extension.Logging;

/// <summary>
/// Default build plan printer that exclusively uses <see cref="ILogger"/>
/// </summary>
/// <param name="logger"></param>
/// <param name="buildContext"></param>
public class PlanLoggerExtension(
    ILogger<PlanLoggerExtension> logger,
    IBuildContext buildContext,
    PlanLoggerOptions options,
    IEnumerable<IOptionsProvider> optionsProviders
) : IBuildInitializedHandler
{
    /// <inheritdoc />
    public async ValueTask OnBuildInitialized()
    {
        if (!options.Plan)
        {
            return;
        }

        LogBuildOptions();
        LogTargets();
    }

    private void LogBuildOptions()
    {
        const string redactedString = "[REDACTED]";
        logger.LogDebug("Arguments:");

        foreach (var argument in optionsProviders.SelectMany(p => p.Arguments))
        {
            logger.LogDebug(
                "{Name} = {Value}",
                argument.Argument.Name,
                argument.Sensitive ? redactedString : argument.RawValue
            );
        }

        logger.LogDebug(string.Empty);

        logger.LogDebug("Options:");

        foreach (var option in optionsProviders.SelectMany(p => p.Options))
        {
            logger.LogDebug(
                "{Name} = {Value}",
                option.Option.Name,
                option.Sensitive ? redactedString : option.RawValue
            );
        }

        logger.LogDebug(string.Empty);
    }

    private void LogTargets()
    {
        var triggeredTargetNames = buildContext.TargetGraph.InvokedTargetsInOrder.Select(t => t.Name);

        logger.LogDebug("Targets:");

        foreach (var invokedTarget in triggeredTargetNames)
        {
            logger.LogDebug("- {TargetName}", invokedTarget);
        }

        logger.LogDebug(string.Empty);
    }
}