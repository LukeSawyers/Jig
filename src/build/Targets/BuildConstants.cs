using Microsoft.Build.Construction;

namespace build.Targets;

public class BuildConstants
{
    public const string SolutionPath = "Jig.sln";

    public static SolutionFile Solution =>
        field ??= SolutionFile.Parse(Path.Combine(Directory.GetCurrentDirectory(), SolutionPath));
}