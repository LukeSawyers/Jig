using System.CommandLine;

namespace Jig.Options;

public interface IBuildOption
{
    object? RawValue { get; }
    
    bool Sensitive { get; }
    
    Option Option { get; }

    /// <summary>
    /// The name used by this option when drawing from environment variables
    /// </summary>
    string EnvName { get; }
    
    void Set(ParseResult parseResult);
}