namespace xBuild.Logging;

public interface IBuildLogger : IBaseLogger
{
    ITargetLogger GetTargetLogger(string targetName);
}