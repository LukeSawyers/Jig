namespace xBuild.Targets;

/// <summary>
///     How a target's failure affects downstream targets
/// </summary>
public enum DownstreamFailureMode
{
    /// <summary>
    ///     All downstream targets are aborted
    /// </summary>
    AbortAll,
    
    /// <summary>
    ///     Downstream targets are unaffected
    /// </summary>
    Continue
}