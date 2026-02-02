namespace Jig.Build;

public enum BuildConcurrency
{
    /// <summary>
    /// Targets are executed one at a time.
    /// </summary>
    Sequential,
    
    /// <summary>
    /// Targets run in parallel, respecting the expressed build ordering. 
    /// </summary>
    Parallel,
}