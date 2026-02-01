using System.CommandLine;

namespace xBuild.Options;

public interface IBuildArgument
{
    object? RawValue { get; }
    
    bool Sensitive { get; }
    
    Argument Argument { get; }

    void Set(ParseResult parseResult);
}