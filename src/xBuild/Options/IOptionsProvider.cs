using System.Reflection;

namespace xBuild.Options;

public interface IOptionsProvider
{
    IEnumerable<IBuildArgument> Arguments => this
        .ReflectProperties<IBuildArgument>(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        .WhereNotNull();

    IEnumerable<IBuildOption> Options => this
        .ReflectProperties<IBuildOption>(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        .WhereNotNull();
}