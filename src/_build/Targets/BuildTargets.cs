using System.CommandLine;
using TacticalNuke.Targets;

namespace _build.Targets;

public class BuildTargets
{
    public const string SolutionPath = "TacticalNuke.sln";

    // System.CommandLine options supported
    public BuildOption<string> Verbosity { get; } = new(
        "minimal",
        new Option<string>("--dotnet-verbosity")
        {
            Description = "Verbosity for dotnet tasks"
        }
    );

    // Targets specified as lazily evaluated properties. Name inferred and description provided:
    private ITarget Build => field ??= new Target(description: "Builds the solution")
        // Targets able to directly execute bash-like commands with shell execution
        .Executes($"""
                   dotnet build {SolutionPath} 
                   --verbosity {Verbosity.Value}
                   """);

    private ITarget Test => field ??= new Target(description: "Tests the solution")
        // Specify the relative ordering of targets
        .After(Build)
        .Executes($"""
                   dotnet test {SolutionPath} 
                   --verbosity {Verbosity.Value}
                   """);

    private ITarget MergeCheck => field ??= new Target(description: "Runs required merge checks")
        // Targets can express dependency relationships, triggering execution of other targets
        .DependsOn(Build, Test);
}