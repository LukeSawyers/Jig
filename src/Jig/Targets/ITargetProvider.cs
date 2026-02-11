using System.Reflection;
using JetBrains.Annotations;
using Jig.Options;
using Jig.Lang;

namespace Jig.Targets;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers | ImplicitUseTargetFlags.WithInheritors)]
public interface ITargetProvider : IOptionsProvider
{
    IEnumerable<ITarget> Targets => this
        .ReflectProperties<ITarget>(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        .WhereNotNull();
}