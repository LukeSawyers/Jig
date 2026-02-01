namespace xBuild.Targets;

/// <summary>
///     How a target responds to a prior target failing
/// </summary>
public enum UpstreamFailureMode
{
    /// <summary>
    ///     The target is aborted if any prior target fails
    /// </summary>
    Abort,
    
    /// <summary>
    ///     The target continues if any prior target fails
    /// </summary>
    Continue
}