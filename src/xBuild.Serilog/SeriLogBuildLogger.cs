using xBuild.Logging;

namespace xBuild.Serilog;

public class SeriLogBuildLogger() : SerilogBaseLogger("Pipeline"), IBuildLogger
{
    public ITargetLogger GetTargetLogger(string targetName) => new SeriLogTargetLogger(targetName);
}