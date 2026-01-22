using Microsoft.Build.Construction;

namespace _build.Targets;

public class BuildConstants
{
    public const string SolutionPath = "xBuild.sln";

    public static SolutionFile Solution =>
        field ??= SolutionFile.Parse(Path.Combine(Directory.GetCurrentDirectory(), SolutionPath));
}