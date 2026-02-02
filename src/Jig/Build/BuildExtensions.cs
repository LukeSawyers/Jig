using System.Reflection;
using Jig.Options;
using Jig.Targets;
using Microsoft.Extensions.DependencyInjection;

namespace Jig.Build;

public static class BuildExtensions
{
    extension(IBuild build)
    {
        /// <summary>
        ///     Adds <typeparamref name="TTargets"/> to the build, making its targets and options available/>
        /// </summary>
        public IBuild AddTargets<TTargets>() where TTargets : class, ITargetProvider
        {
            build.Services.AddSingleton<TTargets>();
            build.Services.AddSingleton<ITargetProvider>(s => s.GetRequiredService<TTargets>());
            build.Services.AddSingleton<IOptionsProvider>(s => s.GetRequiredService<TTargets>());
            return build;
        }
        
        /// <summary>
        ///     Adds all <see cref="ITargetProvider"/> implementations in the entry assembly to the build
        /// </summary>
        public IBuild AddTargetsFromEntryAssembly()
        {
            var targetClasses = Assembly.GetEntryAssembly()
                ?.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(ITargetProvider)) && t is { IsAbstract: false, IsInterface: false })
                .ToArray() ?? [];

            foreach (var targetType in targetClasses)
            {
                build.Services.AddSingleton(targetType);
                build.Services.AddSingleton<ITargetProvider>(s => (ITargetProvider)s.GetRequiredService(targetType));
                build.Services.AddSingleton<IOptionsProvider>(s => (IOptionsProvider)s.GetRequiredService(targetType));
            }

            return build;
        }

        /// <summary>
        ///     Add targets contained specified as static fields in <typeparamref name="TOptions" />
        /// </summary>
        public IBuild AddBuildOptions<TOptions>() where TOptions : class, IOptionsProvider
        {
            build.Services.AddSingleton<TOptions>();
            build.Services.AddSingleton<IOptionsProvider>(s => s.GetRequiredService<TOptions>());
            return build;
        }
        
        /// <summary>
        ///     Add targets contained specified as static fields in <typeparamref name="TOptions" />
        /// </summary>
        public IBuild AddBuildOptions<TOptions>(TOptions instance) where TOptions : class, IOptionsProvider
        {
            build.Services.AddSingleton(instance);
            build.Services.AddSingleton<IOptionsProvider>(s => s.GetRequiredService<TOptions>());
            return build;
        }
    }
}