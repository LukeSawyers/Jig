using System.CommandLine;

namespace xBuild.Options;

public interface IBuildArgument
{
    Argument Argument { get; }

    void Set(ParseResult parseResult);
}