using TacticalNuke.Build;
using TacticalNuke.Serilog;
using _build.Targets;

var arguments = new[]
{
    // "MergeCheck",
    "Inspect",
    // "Cleanup"
    "MergeCheck",
    // "--skip", "RestoreDotnetTools"
    // "-v", "minimal"
    // "--help"
};

await new TacticalNukeBuild(arguments, "src")
    .AddSerilog()
    .AddTargets<BuildTargets>()
    .AddTargets<InspectionTargets>()
    .ExecuteAsync();