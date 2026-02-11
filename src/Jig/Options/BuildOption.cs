using System.CommandLine;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Humanizer;

namespace Jig.Options;

[DebuggerDisplay("{Option.Name}: {Value}")]
public class BuildOption<T>(
    T defaultValue,
    bool sensitive, 
    Option<T> option
) : IBuildOption
{
    public BuildOption(T defaultValue, Option<T> option) : this(defaultValue, false, option)
    {
    }
    
    public BuildOption(
        T defaultValue,
        [CallerMemberName] string name = "",
        string? description = null,
        bool sensitive = false
    ) : this(
        defaultValue,
        sensitive,
        new Option<T>($"--{name.Kebaberize()}")
        {
            Description = description,
            DefaultValueFactory = _ => defaultValue
        }
    )
    {
    }
 
    public T Value { get; private set; } = defaultValue;
    
    /// <inheritdoc/>
    public object? RawValue => Value;
    
    /// <inheritdoc/>
    public bool Sensitive { get; init; } = sensitive; 
    
    /// <inheritdoc/>
    public Option Option => option;

    private string EnvName => option.Name.Trim('-').Underscore().ToUpperInvariant();
    
    /// <inheritdoc/>
    public void Set(ParseResult parseResult)
    {
        // Check CLI
        var cliSpecified = parseResult
            .Tokens
            .Select(t => t.Value)
            .Contains(option.Name);

        var cliValue = parseResult.GetValue(option);
        
        if (cliSpecified && cliValue is not null)
        {
            Value = cliValue;
            return;
        }
        
        // Check Environment
        var envStringVal = Environment.GetEnvironmentVariable(EnvName);

        if (!string.IsNullOrWhiteSpace(envStringVal))
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter.CanConvertFrom(typeof(string)) && converter.ConvertFromString(envStringVal) is T val)
                {
                    Value = val;
                    return;
                }
            }
            catch
            {
                // Noop
            }
        }
        
        // Fall back to default
        Value = defaultValue;
    }

    public static implicit operator T(BuildOption<T> buildOption) => buildOption.Value;

    /// <inheritdoc/>
    public override string ToString() => Value?.ToString() ?? "";
}