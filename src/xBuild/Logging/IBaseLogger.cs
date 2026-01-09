using System.Runtime.CompilerServices;

namespace xBuild.Logging;

public interface IBaseLogger
{
    void Log(BuildLogLevel level, FormattableString log);
    
    /// <summary>
    ///     Logs output messages
    /// </summary>
    /// <param name="log"></param>
    void LogOutput(FormattableString log) => Log(BuildLogLevel.Output, log);
    
    void LogOutputFormat(string format, params object?[] args) => LogOutput(FormattableStringFactory.Create(format, args));    
    
    /// <summary>
    ///     Logs informational messages
    /// </summary>
    /// <param name="log"></param>
    void LogInformation(FormattableString log) => Log(BuildLogLevel.Information, log);

    void LogInformationFormat(string format, params object?[] args) => LogInformation(FormattableStringFactory.Create(format, args));    
    
    /// <summary>
    ///     Logs a warning message
    /// </summary>
    /// <param name="log"></param>
    void LogWarning(FormattableString log) => Log(BuildLogLevel.Warning, log);
    
    void LogWarningFormat(string format, params object?[] args) => LogWarning(FormattableStringFactory.Create(format, args));    
    
    /// <summary>
    ///     Logs an error message
    /// </summary>
    /// <param name="log"></param>
    void LogError(FormattableString log) => Log(BuildLogLevel.Error, log);
    
    void LogErrorFormat(string format, params object?[] args) => LogError(FormattableStringFactory.Create(format, args));
}