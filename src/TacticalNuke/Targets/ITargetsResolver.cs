namespace TacticalNuke.Targets;

public interface ITargetsResolver
{
    IEnumerable<IBuildOption> Options { get; }
    IEnumerable<ITarget> Targets { get; }
}