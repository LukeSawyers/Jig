using Microsoft.Extensions.DependencyInjection;
using xBuild.Build;
using xBuild.Build.Hooks;
using xBuild.Logging;

namespace xBuild.Spectre;

public static class SpectreExtensions
{
    extension<T>(T build) where T : IBuild
    {
        public T AddSpectre()
        {
            build.AddLogging<SpectreBuildLogger>();
            build.Services.AddSingleton<IBuildInitializedHandler>(l => l.GetRequiredService<SpectreBuildLogger>());
            build.Services.AddSingleton<ITargetStartedHandler>(l => l.GetRequiredService<SpectreBuildLogger>());
            build.Services.AddSingleton<ITargetCompletedHandler>(l => l.GetRequiredService<SpectreBuildLogger>());

            return build;
        }
    }
}