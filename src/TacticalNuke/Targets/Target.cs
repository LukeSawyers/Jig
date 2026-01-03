using System.Runtime.CompilerServices;

namespace TacticalNuke.Targets;

public class Target(
    [CallerMemberName] string name = "",
    string description = ""
) : ITarget
{
    private readonly List<ITarget> _afterTargets = new();
    private readonly List<ITarget> _executesTargets = new();

    /// <inheritdoc />
    public string Name { get; } = name;

    /// <inheritdoc />
    public string Description { get; } = description;

    /// <inheritdoc />
    IList<ITarget> ITarget.After => _afterTargets;

    /// <inheritdoc />
    IList<ITarget> ITarget.Triggers => _executesTargets;

    /// <inheritdoc />
    bool ITarget.ExecuteAfterFailure { get; set; }

    /// <inheritdoc />
    bool ITarget.ProceedAfterFailure { get; set; }

    /// <inheritdoc />
    bool ITarget.Unlisted { get; set; }

    /// <inheritdoc />
    Delegate? ITarget.Execution { get; set; }

    public override string ToString() => Name;
}