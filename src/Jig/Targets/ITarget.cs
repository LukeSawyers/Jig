using JetBrains.Annotations;

namespace Jig.Targets;

/// <summary>
/// Minimum required members for an Jig target
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
    List<Func<ITarget>> After { get; }

    /// <summary>
    ///     Targets that are executed after this target
    /// </summary>
    List<Func<ITarget>> Before { get; }

    /// <summary>
    ///     Targets that are executed by this target 
    /// </summary>
    List<Func<ITarget>> Triggers { get; }

    /// <summary>
    ///     Targets that execute by this target 
    /// </summary>
    List<Func<ITarget>> TriggeredBy { get; }

    /// <summary>
    ///     How this target responds to a prior target failing
    /// </summary>
    UpstreamFailureMode UpstreamFailureMode { get; set; }

    /// <summary>
    ///     How this target's failure affects downstream targets
    /// </summary>
    DownstreamFailureMode DownstreamFailureMode { get; set; }

    /// <summary>
    ///     Dynamic delegate to execute for this target
    /// </summary>
    List<TargetExecution> Executions { get; }
}