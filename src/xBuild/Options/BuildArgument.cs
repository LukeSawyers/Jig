using System.CommandLine;

namespace xBuild.Options;

public class BuildArgument<T>(T defaultValue, Argument<T> argument) : IBuildArgument
{
    public T Value { get; private set; } = defaultValue;

    public Argument<T> Argument { get; } = argument;

    Argument IBuildArgument.Argument => Argument;

    public void Set(ParseResult parseResult)
    {
        Value = parseResult.GetValue(Argument) ?? defaultValue;
    }

    public static implicit operator T(BuildArgument<T> buildOption) => buildOption.Value;

    public override string ToString() => $"{Argument.Name}: {Value}";
}