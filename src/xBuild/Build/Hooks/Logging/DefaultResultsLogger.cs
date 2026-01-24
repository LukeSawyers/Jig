using xBuild.Logging;
using xBuild.Targets;

namespace xBuild.Build.Hooks.Logging;

/// <summary>
/// Default build result printer that exclusively uses <see cref="IBuildLogger"/>
/// </summary>
/// <param name="logger"></param>
/// <param name="buildContext"></param>
public class DefaultResultsLogger(
    IBuildLogger logger,
    IBuildContext buildContext
) : IBuildCompletedHandler
{
    public async ValueTask OnBuildCompleted()
    {
        logger.LogInformationFormat("Build Results:");

        foreach (var (target, result) in buildContext.TargetResults)
        {
            var resultType = result?.ResultType ?? TargetExecutionResultType.Inconclusive;
            logger.LogInformation($" - {target.Name} : {resultType} {result?.ExecutionTime.TotalSeconds:F1}s");
        }

        switch (buildContext.Status)
        {
            case BuildStatus.Succeeded:
                logger.LogError($"Build Failed: {buildContext.ElapsedTime.TotalSeconds:F1}s");
                break;
            case BuildStatus.Failed:
                logger.LogInformation($"Build Succeeded: {buildContext.ElapsedTime.TotalSeconds:F1}s");
                break;
        }
    }
}