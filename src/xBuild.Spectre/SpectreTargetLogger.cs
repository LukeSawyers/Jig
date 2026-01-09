using System.Collections.Concurrent;
using Spectre.Console;
using Spectre.Console.Rendering;
using xBuild.Logging;
using xBuild.Targets;

namespace xBuild.Spectre;

public class SpectreTargetLogger(
    string targetName,
    ProgressTask progressTask
) : ITargetLogger
{
    private readonly ConcurrentQueue<IRenderable> _logs = new();

    public void TargetStarted()
    {
        progressTask.Description = SpectreBuildLogger.FormatProgressDescription(targetName, true);
        progressTask.StartTask();
    }

    public void TargetCompleted(TargetExecutionResult result)
    {
        progressTask.Description = SpectreBuildLogger.FormatProgressDescription(targetName, result.ResultType);
        progressTask.StopTask();
    }

    public void Log(BuildLogLevel level, FormattableString log)
    {
        progressTask.Description = SpectreBuildLogger.FormatProgressDescription(
            targetName,
            true,
            level,
            log
        );
    }
}