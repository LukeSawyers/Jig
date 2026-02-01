using Microsoft.Extensions.DependencyInjection;
using xBuild.Options;

namespace xBuild.Build.Extension.Logging;

public static class DefaultLoggingExtensions
{
    extension<T>(T build) where T : IBuild
    {
        /// <summary>
        /// Adds default logging hooks and supporting services to the build
        /// </summary>
        /// <returns></returns>
        public T AddDefaultLoggingExtensions()
        {
            // List Extension
            build.Services.AddSingleton<ListExtension>()
                .AddSingleton<IBuildInitializedHandler>(s => s.GetRequiredService<ListExtension>())
                .AddSingleton<IOptionsProvider>(s => s.GetRequiredService<ListExtension>())

                // Plan extension
                .AddSingleton<PlanLoggerExtension>()
                .AddSingleton<IBuildInitializedHandler>(ctx => ctx.GetRequiredService<PlanLoggerExtension>())
                .AddSingleton<PlanLoggerOptions>()
                .AddSingleton<IOptionsProvider>(ctx => ctx.GetRequiredService<PlanLoggerOptions>())

                // Dry Run extension
                .AddSingleton<DryRunExtension>()
                .AddSingleton<IBuildInitializedHandler>(s => s.GetRequiredService<DryRunExtension>())
                .AddSingleton<IOptionsProvider>(s => s.GetRequiredService<DryRunExtension>())

                // Results logger extension
                .AddSingleton<ResultsLoggerExtension>()
                .AddSingleton<IBuildCompletedHandler>(s => s.GetRequiredService<ResultsLoggerExtension>());

            return build;
        }
    }
}