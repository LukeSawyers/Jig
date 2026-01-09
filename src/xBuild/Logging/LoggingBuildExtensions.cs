using Microsoft.Extensions.DependencyInjection;
using xBuild.Build;
using xBuild.Targets;

namespace xBuild.Logging;

public static class LoggingBuildExtensions
{
    extension(IBuild build)
    {
        public IBuild AddLogging<T>() where T: class, IBuildLogger
        {
            build.Services.AddSingleton<T>();
            build.Services.AddSingleton<IBuildLogger>(ctx => ctx.GetRequiredService<T>());
            build.Services.AddScoped<ITargetLogger>(ctx =>
            {
                var targetContext = ctx.GetRequiredService<TargetContext>().Target.Name;
                return ctx.GetRequiredService<IBuildLogger>().GetTargetLogger(targetContext);
            });

            return build;
        } 
    }
}