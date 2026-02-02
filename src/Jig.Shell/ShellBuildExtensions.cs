using Microsoft.Extensions.DependencyInjection;
using Jig.Build;

namespace Jig.Shell;

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