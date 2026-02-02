using System.CommandLine;
using Jig.Options;

namespace Jig.Build;

/// <summary>
///     Built-in build options that govern pipeline execution.
///     Extensible to add more parameters to the build pipeline.
/// </summary>
public class BuildOptions(BuildConcurrency defaultBuildConcurrency) : IOptionsProvider
{
    public BuildArgument<IEnumerable<string>> Target { get; } = new(
        [],
        new Argument<IEnumerable<string>>("targets")
        {
            Description = "Targets to include in the build. " +
                          "Targets specified and their dependencies (.Triggers, .DependsOn) are added to the target execution graph.",
            Arity = ArgumentArity.ZeroOrMore
        }
    );

    public BuildOption<IEnumerable<string>> Exclude { get; } = new(
        [],
        new Option<IEnumerable<string>>("--exclude")
        {
            Description = "Targets to exclude from the build. " +
                          "Excluding a target makes the build act as if it does not exist. " +
                          "Excluded targets are not made available when building the target execution graph. " +
                          "As such their dependencies, (.Triggers, .DependsOn) are not evaluated and are not included, " +
                          "unless another included target also requires them. " +
                          "Excluded targets are not shown in logs or build reports.",
            AllowMultipleArgumentsPerToken = true,
            Arity = ArgumentArity.OneOrMore
        }
    );

    public BuildOption<IEnumerable<string>> Skip { get; } = new(
        [],
        new Option<IEnumerable<string>>("--skip")
        {
            Description = "Targets to skip during the build. " +
                          "Skipped targets are included in the build as normal, but their executions are not run, " +
                          "and their result after running is always 'Skipped'",
            AllowMultipleArgumentsPerToken = true,
            Arity = ArgumentArity.OneOrMore
        }
    );
    
    public BuildOption<BuildConcurrency> BuildConcurrency { get; } = new(
        defaultBuildConcurrency,
        new Option<BuildConcurrency>("--build-concurrency")
        {
            Description = $"Sets the build concurrency (default: {defaultBuildConcurrency})",
        }
    );
}