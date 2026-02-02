using System.CommandLine;

namespace Jig.Options;

public interface IBuildArgument
{
    object? RawValue { get; }
    
    bool Sensitive { get; }
    
    Argument Argument { get; }

    void Set(ParseResult parseResult);
}