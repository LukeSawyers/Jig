using Jig.Targets;
using Microsoft.Extensions.Logging;
using QuikGraph.Algorithms;

namespace Jig.Build.Extension.Logging;

/// <summary>
/// Default build result logger
/// </summary>
/// <param name="logger"></param>
/// <param name="buildContext"></param>
public class ResultsLoggerExtension(
    ILogger<ResultsLoggerExtension> logger,
    IBuildContext buildContext
) : IBuildCompletedHandler
{
    /// <inheritdoc />
    public async ValueTask OnBuildCompleted()
    {
        logger.LogDebug("");
        logger.LogDebug("Build Results:");

        var template = "{TargetName} {ResultType} {ExecutionTime:F1}s";
        var targetNameMaxLength = buildContext.TargetResults.Keys.Max(t => t.Name.Length) + 5;
        var resultTypeMaxLength = buildContext.TargetResults.Values.Max(t => t?.ResultType.ToString().Length ?? 0) + 5;

        var targetsInOrder = buildContext.TargetGraph.AllTargetsExecutionGraph.TopologicalSort()
            .Where(t => buildContext.TargetResults.ContainsKey(t))
            .Reverse();
        
        foreach (var target in targetsInOrder)
        {
            var result = buildContext.TargetResults[target];
            var resultType = result?.ResultType ?? TargetExecutionResultType.Inconclusive;
            var logLevel = resultType switch
            {
                TargetExecutionResultType.Inconclusive => LogLevel.Warning,
                TargetExecutionResultType.Succeeded => LogLevel.Information,
                TargetExecutionResultType.Skipped => LogLevel.Warning,
                TargetExecutionResultType.Aborted => LogLevel.Error,
                TargetExecutionResultType.Failed => LogLevel.Error,
                _ => LogLevel.Debug
            };
            
            logger.Log(
                logLevel,
                template,
                target.Name.PadRight(targetNameMaxLength),
                resultType.ToString().PadRight(resultTypeMaxLength),
                result?.ExecutionTime.TotalSeconds
            );
        }

        switch (buildContext.Status)
        {
            case BuildStatus.Succeeded:
                logger.LogInformation("Build Succeeded: {ElapsedTime:F1}s", buildContext.ElapsedTime.TotalSeconds);
                break;
            case BuildStatus.Failed:
                logger.LogError("Build Failed: {ElapsedTime:F1}s", buildContext.ElapsedTime.TotalSeconds);
                break;
        }
        
        logger.LogDebug("");
    }
}