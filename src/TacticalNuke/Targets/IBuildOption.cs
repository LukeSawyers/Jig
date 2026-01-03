using System.CommandLine;

namespace TacticalNuke.Targets;

public interface IBuildOption
{
    Option Option { get; }

    void Set(ParseResult parseResult);
}