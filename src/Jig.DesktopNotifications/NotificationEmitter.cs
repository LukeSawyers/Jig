using CliWrap;
using Jig.Build;
using Jig.Build.Extension;
using Jig.Shell;
using Jig.Targets;

namespace Jig.DesktopNotifications;

public class NotificationEmitter(
    Shell.Shell shell,
    IBuildContext buildContext
) : ITargetCompletedHandler, IBuildCompletedHandler
{
    public ValueTask OnBuildCompleted() => EmitNotification(
        $"Build {buildContext.Status} in {buildContext.ElapsedTime.TotalSeconds:F1}s"
    );

    public async ValueTask OnTargetCompleted(ITarget target, TargetExecutionResult result)
    {
        if (result.ResultType != TargetExecutionResultType.Failed)
        {
            return;
        }

        await EmitNotification(
            $"Target {target.Name} Failed in {result.ExecutionTime.TotalSeconds:F1}s"
        );
    }

    private async ValueTask EmitNotification(string message)
    {
        if (OperatingSystem.IsLinux())
        {
            await shell.Command(
                    $"notify-send --transient --app-name=Jig \"{message}\"",
                    logging: ShellLoggingOptions.StandardError
                )
                .WithValidation(CommandResultValidation.None)
                .ExecuteAsync();
        }
        else if (OperatingSystem.IsMacOS())
        {
            await shell.Command(
                    $"osascript -e \"display notification \\\"{message}\\\"",
                    logging: ShellLoggingOptions.StandardError
                )
                .WithValidation(CommandResultValidation.None)
                .ExecuteAsync();
        }
        else if (OperatingSystem.IsWindows())
        {
#if WINDOWS
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Andrew sent you a picture")
                .AddText("Check this out, The Enchantments in Washington!")
                .Show();
#endif
        }
    }
}