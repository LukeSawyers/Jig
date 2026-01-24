using JetBrains.Annotations;

namespace xBuild.Targets;

/// <summary>
/// Minimum required members for an xBuild target
/// </summary>
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
    ///     true: Target is not shown in CLI, but still invokable
    /// </summary>
    bool Unlisted { get; set; }

    /// <summary>
    ///     Targets that are executed before this target
    /// </summary>
    IList<Func<ITarget>> After { get; }

    /// <summary>
    ///     Targets that are executed after this target
    /// </summary>
    IList<Func<ITarget>> Before { get; }

    /// <summary>
    ///     Targets that are executed by this target 
    /// </summary>
    IList<Func<ITarget>> Triggers { get; }

    /// <summary>
    ///     Targets that execute by this target 
    /// </summary>
    IList<Func<ITarget>> TriggeredBy { get; }

    /// <summary>
    ///     true: Execute this target even if a prior task fails
    /// </summary>
    bool ExecuteAfterFailure { get; set; }

    /// <summary>
    ///     true: Proceed with the build even if this task fails
    /// </summary>
    bool ProceedAfterFailure { get; set; }

    /// <summary>
    ///     Dynamic delegate to execute for this target
    /// </summary>
    IList<TargetExecution> Executions { get; }
}