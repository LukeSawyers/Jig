using Jig.Options;
using Microsoft.Extensions.Logging;

namespace Jig.Build.Extension.Logging;

public class DryRunExtension(
    ILogger<DryRunExtension> logger,
    IBuildContext buildContext
) : IBuildInitializedHandler, IOptionsProvider
{
    BuildOption<bool> DryRun { get; } = new(
        false,
        description: "Print a descriptive list of tasks to be run instead of running them"
    );

    public async ValueTask OnBuildInitialized()
    {
        if (!DryRun)
        {
            return;
        }

        logger.LogInformation("Dry Run:");
        logger.LogInformation("");

        foreach (var target in buildContext.TargetGraph.InvokedTargetsInOrder)
        {
            logger.LogInformation("{TargetName}:", target.Name);

            if (!target.Executions.Any())
            {
                logger.LogInformation(" - Target has no executions");
            }
            else if (target.Executions.All(e => string.IsNullOrWhiteSpace(e.Description.Format)))
            {
                logger.LogInformation(" - Target has {Count} undescribed executions", target.Executions.Count);
            }
            else
            {
                foreach (var execution in target.Executions)
                {
                    logger.LogInformation($" - {execution.Description.Format}", execution.Description.GetArguments());
                }
            }

            logger.LogInformation("");
        }

        // Cancel the build
        buildContext.Cancel();
    }
}