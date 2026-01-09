using xBuild.Logging;

namespace xBuild.Shell;

public class TargetShell(ITargetLogger logger ) : Shell(logger);