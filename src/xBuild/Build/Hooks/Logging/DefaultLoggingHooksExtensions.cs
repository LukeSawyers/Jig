using Microsoft.Extensions.DependencyInjection;

namespace xBuild.Build.Hooks.Logging;

public static class DefaultLoggingHooksExtensions
{
    extension<T>(T build) where T: IBuild
    {
        /// <summary>
        /// Adds default logging hooks and supporting services to the build
        /// </summary>
        /// <returns></returns>
        public T AddDefaultLoggingHooks()
        {
            build.AddBuildOptions<DefaultLoggingHooksOptionsProvider>();
            build.Services.AddSingleton<IBuildCompletedHandler, DefaultResultsLogger>();
            return build;
        }
    }
}