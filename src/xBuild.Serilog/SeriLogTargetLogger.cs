using xBuild.Logging;

namespace xBuild.Serilog;

public class SeriLogTargetLogger(string targetName) : SerilogBaseLogger(targetName), ITargetLogger
{
    public void LogCommand(string command) => (this as IBaseLogger).LogInformationFormat(command);
}