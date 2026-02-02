using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Jig.Targets;

[DebuggerDisplay($"{{{nameof(Name)}}}")]
public class Target(
    [CallerMemberName] string name = "",
    string description = ""
) : ITarget
{
    /// <inheritdoc />
    public string Name { get; } = name;
    
    /// <inheritdoc />
    public string Description { get; } = description;

    /// <inheritdoc />
    List<Func<ITarget>> ITarget.After { get; } = new();

    /// <inheritdoc />
    List<Func<ITarget>> ITarget.Before { get; } = new();

    /// <inheritdoc />
    List<Func<ITarget>> ITarget.Triggers { get; } = new();

    /// <inheritdoc />
    List<Func<ITarget>> ITarget.TriggeredBy { get; } = new();

    /// <inheritdoc />
    UpstreamFailureMode ITarget.UpstreamFailureMode { get; set; } = UpstreamFailureMode.Abort;

    /// <inheritdoc />
    DownstreamFailureMode ITarget.DownstreamFailureMode { get; set; } = DownstreamFailureMode.AbortAll;

    /// <inheritdoc />
    bool ITarget.Unlisted { get; set; }

    /// <inheritdoc />
    List<TargetExecution> ITarget.Executions { get; } = new();
}