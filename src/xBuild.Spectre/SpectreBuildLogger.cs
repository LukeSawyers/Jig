using QuikGraph.Algorithms;
using Spectre.Console;
using xBuild.Build;
using xBuild.Build.Hooks;
using xBuild.Logging;
using xBuild.Targets;

namespace xBuild.Spectre;

public class SpectreBuildLogger :
    IBuildLogger,
    IBuildInitializedHandler,
    ITargetStartedHandler,
    ITargetCompletedHandler,
    IAsyncDisposable
{
    public static string FormatProgressDescription(string targetName, TargetExecutionResultType resultType)
    {
        var style = resultType switch
        {
            TargetExecutionResultType.Inconclusive => "yellow",
            TargetExecutionResultType.Succeeded => "green",
            TargetExecutionResultType.Skipped => "gray",
            TargetExecutionResultType.Aborted => "red",
            TargetExecutionResultType.Failed => "red",
            _ => "magenta"
        };

        var content = Markup.Escape($"{targetName} [{resultType.ToString()}]");
        return $"[{style}]{content}[/]";
    }

    public static string FormatProgressDescription(string targetName, bool started)
    {
        return FormatProgressDescription(targetName, started, BuildLogLevel.Output, $"");
    }

    public static string FormatProgressDescription(
        string targetName,
        bool started,
        BuildLogLevel lastLogLevel,
        FormattableString lastLogString
    )
    {
        var targetStyle = started ? "blue" : "gray";
        var status = started ? "Running" : "Pending";

        var targetContent = Markup.Escape($"{targetName} [{status}]");

        var lastLogStyle = lastLogLevel switch
        {
            BuildLogLevel.Output => "gray",
            BuildLogLevel.Information => "blue",
            BuildLogLevel.Warning => "yellow",
            BuildLogLevel.Error => "red",
            _ => "gray"
        };

        var logString = lastLogString
            .ToString()
            .PadRight(100)
            .Substring(0, 100)
            .Let(Markup.Escape);
        
        return $"[{lastLogStyle}]{logString}[/] [bold][{targetStyle}]{targetContent}[/][/]";
    }

    private readonly Dictionary<string, SpectreTargetLogger> _targetLoggers = new();
    private readonly IBuildContext _buildContext;

    private readonly TaskCompletionSource _completion = new();

    private ProgressContext? _progressContext;
    private Task _progressTask;

    public SpectreBuildLogger(IBuildContext buildContext)
    {
        _buildContext = buildContext;

        _progressTask = AnsiConsole.Progress()
            .HideCompleted(false)
            .AutoClear(false)
            .AutoRefresh(true)
            .Columns(
                new SpinnerColumn(),
                new TaskDescriptionColumn(),
                new ElapsedTimeColumn()
            )
            .StartAsync(async ctx =>
            {
                _progressContext = ctx;
                await _completion.Task;
            });
    }

    public ITargetLogger GetTargetLogger(string targetName) => GetOrAddTargetLogger(targetName);

    private SpectreTargetLogger GetOrAddTargetLogger(string targetName)
    {
        return _targetLoggers.TryGetValue(targetName, out var controller)
            ? controller
            : _targetLoggers[targetName] = new SpectreTargetLogger(
                targetName,
                _progressContext!.AddTask(FormatProgressDescription(targetName, false), false)
            );
    }

    public async ValueTask OnBuildInitialized()
    {
        var executingTargets = _buildContext.Targets.Keys.ToHashSet();
        var targetsInOrder = _buildContext.TargetGraph.TriggerGraph
            .TopologicalSort()
            .Where(t => executingTargets.Contains(t))
            .Reverse();

        foreach (var target in targetsInOrder)
        {
            GetTargetLogger(target.Name);
        }
    }

    public void Log(BuildLogLevel level, FormattableString log)
    {
        // AddLog(_logs, level, log);
        // var body = new Rows(_logs);
        // _logsContext?.UpdateTarget(body);
    }

    public async ValueTask OnTargetStarted(
        ITarget target
    ) => GetOrAddTargetLogger(target.Name).TargetStarted();

    public async ValueTask OnTargetCompleted(
        ITarget target,
        TargetExecutionResult result
    ) => GetOrAddTargetLogger(target.Name).TargetCompleted(result);

    public async ValueTask DisposeAsync()
    {
        if (!_completion.Task.IsCompleted)
        {
            _completion.SetResult();
        }

        await _progressTask;
    }
}