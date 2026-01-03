namespace TacticalNuke.Targets;

public interface ITarget
{
    /// <summary>
    ///     The name of this target
    /// </summary>
    string Name { get; }

    /// <summary>
    ///     Description of this target
    /// </summary>
    string Description { get; }

    /// <summary>
    ///     Tasks that are executed before this target
    /// </summary>
    IList<ITarget> After { get; }

    /// <summary>
    ///     Tasks that are executed
    /// </summary>
    IList<ITarget> Triggers { get; }

    /// <summary>
    ///     true: Execute this target even if a prior task fails
    /// </summary>
    bool ExecuteAfterFailure { get; set; }

    /// <summary>
    ///     true: Proceed with the build even if this task fails
    /// </summary>
    bool ProceedAfterFailure { get; set; }

    /// <summary>
    ///     true: Target is not shown in CLI, but still invokable
    /// </summary>
    bool Unlisted { get; set; }

    /// <summary>
    ///     Dynamic delegate to execute for this target
    /// </summary>
    Delegate? Execution { get; set; }
}