using System.Reflection;

namespace TacticalNuke.Targets;

public class TargetsResolver<T>(T targetSource) : ITargetsResolver
{
    public IEnumerable<IBuildOption> Options => field ??= typeof(T)
        .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        .Where(f => f.PropertyType.IsAssignableTo(typeof(IBuildOption)))
        .Select(f => f.GetValue(targetSource) as IBuildOption)
        .WhereNotNull()
        .ToArray();

    public IEnumerable<ITarget> Targets => field ??= typeof(T)
        .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        .Where(f => f.PropertyType.IsAssignableTo(typeof(ITarget)))
        .Select(f => f.GetValue(targetSource) as ITarget)
        .WhereNotNull()
        .ToArray();
}