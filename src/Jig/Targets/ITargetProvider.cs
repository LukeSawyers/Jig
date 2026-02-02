using System.Reflection;
using Jig.Options;
using Jig.Lang;

namespace Jig.Targets;

public interface ITargetProvider : IOptionsProvider
{
    IEnumerable<ITarget> Targets => this
        .ReflectProperties<ITarget>(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        .WhereNotNull();
}