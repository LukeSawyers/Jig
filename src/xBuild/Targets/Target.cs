using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace xBuild.Targets;

[DebuggerDisplay($"{{{nameof(Name)}}}")]
public class Target(
    [CallerMemberName] string name = "",
    string description = ""
) : ITarget
{
    private readonly List<Func<ITarget>> _afterTargets = new();
    private readonly List<Func<ITarget>> _beforeTargets = new();
    private readonly List<Func<ITarget>> _triggersTargets = new();
    private readonly List<Func<ITarget>> _triggeredByTargets = new();

    /// <inheritdoc />
    public string Name { get; } = name;
    
    /// <inheritdoc />
    public string Description { get; } = description;

    /// <inheritdoc />
    IList<Func<ITarget>> ITarget.After => _afterTargets;
    
    /// <inheritdoc />
    IList<Func<ITarget>> ITarget.Before => _beforeTargets;

    /// <inheritdoc />
    IList<Func<ITarget>> ITarget.Triggers => _triggersTargets;
    
    /// <inheritdoc />
    IList<Func<ITarget>> ITarget.TriggeredBy => _triggeredByTargets;

    /// <inheritdoc />
    bool ITarget.ExecuteAfterFailure { get; set; }

    /// <inheritdoc />
    bool ITarget.ProceedAfterFailure { get; set; }

    /// <inheritdoc />
    bool ITarget.Unlisted { get; set; }

    /// <inheritdoc />
    IList<Delegate> ITarget.Executions { get; } = new List<Delegate>();
}