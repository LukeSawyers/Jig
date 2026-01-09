using System.Diagnostics;

namespace xBuild.Targets;

public class TargetContext
{
    /// <summary>
    /// The target being executed
    /// </summary>
    /// <returns></returns>
    public ITarget Target { get; internal set; } = null!;

    internal Stopwatch Stopwatch { get; } = new();
}