using Jig.Build;
using Jig.Build.Extension;
using Jig.Shell;
using Microsoft.Extensions.DependencyInjection;

namespace Jig.DesktopNotifications;

public static class NotificationExtensions
{
    extension<T>(T build) where T : IBuild
    {
        public T AddNotifications()
        {
            build.AddShell();
            build.Services.AddSingleton<NotificationEmitter>();
            build.Services.AddSingleton<ITargetCompletedHandler>(s => s.GetRequiredService<NotificationEmitter>());
            build.Services.AddSingleton<IBuildCompletedHandler>(s => s.GetRequiredService<NotificationEmitter>());
            return build;
        }
    }
}