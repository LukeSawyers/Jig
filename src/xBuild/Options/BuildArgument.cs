using System.CommandLine;

namespace xBuild.Options;

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

    public T Value { get; private set; } = defaultValue;

    /// <inheritdoc/>
    public object? RawValue => Value;

    /// <inheritdoc/>
    public bool Sensitive { get; } = sensitive;

    /// <inheritdoc/>
    Argument IBuildArgument.Argument => argument;

    /// <inheritdoc/>
    public void Set(ParseResult parseResult)
    {
        Value = parseResult.GetValue(argument) ?? defaultValue;
    }

    public static implicit operator T(BuildArgument<T> buildOption) => buildOption.Value;

    public override string ToString() => Value?.ToString() ?? string.Empty;
}