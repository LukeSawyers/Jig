using Jig.Targets;

namespace Jig.Build;

public interface IBuildContext
{
    /// <summary>
    ///     The repository root directory, i.e. the location of the .git folder
    /// </summary>
    public static string RepositoryRootDirectory { get; internal set; } = Directory.GetCurrentDirectory();

    /// <summary>
    ///     The current working directory
    /// </summary>
    public static string CurrentDirectory => Directory.GetCurrentDirectory();

    /// <summary>
    /// The current status of the build
    /// </summary>
    BuildStatus Status { get; }

    /// <summary>
    /// The time elapsed since the build started
    /// </summary>
    TimeSpan ElapsedTime { get; }

    /// <summary>
    /// The target graph constructed for the build
    /// </summary>
    TargetGraph TargetGraph { get; }

    /// <summary>
    /// Results of targets that are to be executed in the build.
    /// Null result means the target hasn't been executed yet.
    /// </summary>
    IDictionary<ITarget, TargetExecutionResult?> TargetResults { get; }

    /// <summary>
    /// Outputs returned by target executions
    /// </summary>
    IDictionary<Type, object> TargetOutputs { get; }

    /// <summary>
    /// Token representing build cancellation (e.g. if ctrl+c is pressed)
    /// </summary>
    CancellationToken BuildCancelled { get; }

    /// <summary>
    /// Cancels the build
    /// </summary>
    void Cancel();
}