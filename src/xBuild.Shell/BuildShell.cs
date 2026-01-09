using xBuild.Logging;

namespace xBuild.Shell;

public class BuildShell(IBuildLogger logger) : Shell(logger);