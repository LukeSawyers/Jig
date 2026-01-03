using System.CommandLine;

namespace TacticalNuke.Targets;

public class BuildOption<T>(T defaultValue, Option<T> option) : IBuildOption
{
    public T Value { get; set; } = defaultValue;
    public Option<T> Option { get; } = option;

    Option IBuildOption.Option => Option;

    public void Set(ParseResult parseResult)
    {
        Value = parseResult.GetValue(Option) ?? defaultValue;
    }
}