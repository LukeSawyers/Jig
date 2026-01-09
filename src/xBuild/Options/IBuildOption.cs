using System.CommandLine;

namespace xBuild.Options;

public interface IBuildOption
{
    object? RawValue { get; }
    
    bool Sensitive { get; }
    
    Option Option { get; }

    void Set(ParseResult parseResult);
}