using Microsoft.Extensions.DependencyInjection;
using xBuild.Build;

namespace xBuild.Shell;

public static class ShellBuildExtensions
{
    extension<T>(T build) where T : IBuild
    {
        public T AddShell()
        {
            build.Services.AddSingleton<Shell>();
            return build;
        }
    }
}