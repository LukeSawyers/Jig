using System.CommandLine;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Humanizer;

namespace Jig.Options;

public class BuildArgument<T>(
    T defaultValue,
    bool sensitive,
    Argument<T> argument
) : IBuildArgument
{
    public BuildArgument(
        T defaultValue,
        Argument<T> argument
    ) : this(defaultValue, false, argument)
    {
    }
    
    public BuildArgument(
        T defaultValue,
        [CallerMemberName] string name = "",
        string? description = null,
        bool sensitive = false
    ) : this(
        defaultValue,
        sensitive,
        new Argument<T>($"--{name.Kebaberize()}")
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
    public bool Sensitive { get; } = sensitive;

    /// <inheritdoc/>
    public Argument Argument => argument;

    private string EnvName => argument.Name.Trim('-').Underscore().ToUpperInvariant();
    
    /// <inheritdoc/>
    public void Set(ParseResult parseResult)
    {
        Value = parseResult.GetValue(argument) ?? defaultValue;
        
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
    }

    public static implicit operator T(BuildArgument<T> buildOption) => buildOption.Value;

    public override string ToString() => Value?.ToString() ?? string.Empty;
}