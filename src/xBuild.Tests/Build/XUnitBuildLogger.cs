using xBuild.Logging;
using Xunit.Abstractions;

namespace xBuild.Tests.Build;

public class XUnitBuildLogger(ITestOutputHelper outputHelper) : IBuildLogger
{
    public void Log(BuildLogLevel level, FormattableString log) => outputHelper.WriteLine($"{level}: {log}");

    public ITargetLogger GetTargetLogger(string targetName) => new XUnitTargetLogger(targetName, outputHelper);
}