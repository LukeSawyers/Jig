using System.Reflection;
using xBuild.Options;

namespace xBuild.Targets;

public interface ITargetProvider : IOptionsProvider
{
    IEnumerable<ITarget> Targets => this
        .ReflectProperties<ITarget>(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        .WhereNotNull();
}