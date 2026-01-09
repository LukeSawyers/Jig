using Microsoft.Extensions.DependencyInjection;
using xBuild.Options;
using xBuild.Targets;

namespace xBuild.Build;

public static class BuildExtensions
{
    extension(IBuild build)
    {
        /// <summary>
        ///     Add targets contained specified as static fields in <typeparamref name="T" />
        /// </summary>
        public IBuild AddTargets<TTargets>() where TTargets : class, ITargetProvider
        {
            build.Services.AddSingleton<TTargets>();
            build.Services.AddSingleton<ITargetProvider>(s => s.GetRequiredService<TTargets>());
            build.Services.AddSingleton<IOptionsProvider>(s => s.GetRequiredService<TTargets>());
            return build;
        }

        /// <summary>
        ///     Add targets contained specified as static fields in <typeparamref name="T" />
        /// </summary>
        public IBuild AddBuildOptions<TOptions>() where TOptions : class, IOptionsProvider
        {
            build.Services.AddSingleton<TOptions>();
            build.Services.AddSingleton<IOptionsProvider>(s => s.GetRequiredService<TOptions>());
            return build;
        }
        
        /// <summary>
        ///     Add targets contained specified as static fields in <typeparamref name="T" />
        /// </summary>
        public IBuild AddBuildOptions<TOptions>(TOptions instance) where TOptions : class, IOptionsProvider
        {
            build.Services.AddSingleton(instance);
            build.Services.AddSingleton<IOptionsProvider>(s => s.GetRequiredService<TOptions>());
            return build;
        }
    }
}