using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using TacticalNuke.Build;

namespace TacticalNuke.Serilog;

public static class SerilogExtensions
{
    public static ConsoleTheme DefaultSystemColorTheme => new SystemConsoleTheme(
        new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
        {
            [ConsoleThemeStyle.Text] = new(),
            [ConsoleThemeStyle.SecondaryText] = new() { Foreground = ConsoleColor.Gray },
            [ConsoleThemeStyle.TertiaryText] = new() { Foreground = ConsoleColor.Gray },
            [ConsoleThemeStyle.Name] = new() { Foreground = ConsoleColor.Blue },
            [ConsoleThemeStyle.Invalid] = new() { Foreground = ConsoleColor.DarkRed },
            [ConsoleThemeStyle.Null] = new() { Foreground = ConsoleColor.Cyan },
            [ConsoleThemeStyle.String] = new() { Foreground = ConsoleColor.Cyan },
            [ConsoleThemeStyle.Number] = new() { Foreground = ConsoleColor.Cyan },
            [ConsoleThemeStyle.Boolean] = new() { Foreground = ConsoleColor.Cyan },
            [ConsoleThemeStyle.Scalar] = new() { Foreground = ConsoleColor.Cyan },
            [ConsoleThemeStyle.LevelVerbose] = new()
            {
                Foreground = ConsoleColor.White,
                Background = ConsoleColor.Gray
            },
            [ConsoleThemeStyle.LevelDebug] = new()
            {
                Foreground = ConsoleColor.White,
                Background = ConsoleColor.DarkGray
            },
            [ConsoleThemeStyle.LevelInformation] = new()
            {
                Foreground = ConsoleColor.White,
                Background = ConsoleColor.Cyan
            },
            [ConsoleThemeStyle.LevelWarning] = new()
            {
                Foreground = ConsoleColor.White,
                Background = ConsoleColor.Yellow
            },
            [ConsoleThemeStyle.LevelError] = new()
            {
                Foreground = ConsoleColor.White,
                Background = ConsoleColor.Red
            },
            [ConsoleThemeStyle.LevelFatal] = new()
            {
                Foreground = ConsoleColor.White,
                Background = ConsoleColor.DarkRed
            }
        });

    extension(TacticalNukeBuild build)
    {
        public TacticalNukeBuild AddSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console(
                    outputTemplate:
                    "[{Level:u3}] {ExecutingTarget} {Timestamp:HH:mm:ss}: {Message:l}{NewLine}{Exception}",
                    theme: DefaultSystemColorTheme,
                    applyThemeToRedirectedOutput: true)
                .Enrich.FromLogContext()
                .MinimumLevel.Verbose()
                .CreateLogger();

            build.Services.AddLogging(b => b
                .ClearProviders()
                .AddSerilog(Log.Logger));

            return build;
        }
    }
}