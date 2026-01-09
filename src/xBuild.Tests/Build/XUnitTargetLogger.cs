using xBuild.Logging;
using Xunit.Abstractions;

namespace xBuild.Tests.Build;

public class XUnitTargetLogger(string targetName, ITestOutputHelper outputHelper) : ITargetLogger
{
    public void Log(BuildLogLevel level, FormattableString log) => outputHelper.WriteLine($"{level}: {targetName} - {log}");
}