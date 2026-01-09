using Serilog.Events;
using xBuild.Logging;

namespace xBuild.Serilog;

public abstract class SerilogBaseLogger(string scope) : IBaseLogger
{
    public void Log(BuildLogLevel level, FormattableString log)
    {
        var format = $"{scope}: {log.Format}";

        var serilogLevel = level switch
        {
            BuildLogLevel.Output => LogEventLevel.Debug,
            BuildLogLevel.Information => LogEventLevel.Information,
            BuildLogLevel.Warning => LogEventLevel.Warning,
            BuildLogLevel.Error => LogEventLevel.Error,
            _ => throw new ArgumentOutOfRangeException(nameof(level), level, null)
        };
        
        global::Serilog.Log.Logger.Write(serilogLevel, format, log.GetArguments());
    }
}