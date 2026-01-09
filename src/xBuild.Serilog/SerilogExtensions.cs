using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using xBuild.Build;
using xBuild.Logging;

namespace xBuild.Serilog;

public static class SerilogExtensions
{
    public static ConsoleTheme DefaultSystemColorTheme => new SystemConsoleTheme(
        new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>
        {
            [ConsoleThemeStyle.Text] = new(),
            [ConsoleThemeStyle.SecondaryText] = new()
            {
                Foreground = ConsoleColor.Gray
            },
            [ConsoleThemeStyle.TertiaryText] = new()
            {
                Foreground = ConsoleColor.Gray
            },
            [ConsoleThemeStyle.Name] = new()
            {
                Foreground = ConsoleColor.Blue
            },
            [ConsoleThemeStyle.Invalid] = new()
            {
                Foreground = ConsoleColor.DarkRed
            },
            [ConsoleThemeStyle.Null] = new()
            {
                Foreground = ConsoleColor.Cyan
            },
            [ConsoleThemeStyle.String] = new()
            {
                Foreground = ConsoleColor.Cyan
            },
            [ConsoleThemeStyle.Number] = new()
            {
                Foreground = ConsoleColor.Cyan
            },
            [ConsoleThemeStyle.Boolean] = new()
            {
                Foreground = ConsoleColor.Cyan
            },
            [ConsoleThemeStyle.Scalar] = new()
            {
                Foreground = ConsoleColor.Cyan
            },
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

    extension<T>(T build) where T : IBuild
    {
        public T AddSerilog(Func<LoggerConfiguration, LoggerConfiguration>? configure = null)
        {
            var configuration = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Verbose()
                .WriteTo.Console(
                    outputTemplate: "[{Level:u3}] {Timestamp:HH:mm:ss}: {Message:l}{NewLine}{Exception}",
                    theme: DefaultSystemColorTheme,
                    applyThemeToRedirectedOutput: true
                );

            if (configure != null)
            {
                configuration = configure(configuration);
            }

            Log.Logger = configuration.CreateLogger();

            build.AddLogging<SeriLogBuildLogger>();

            return build;
        }
    }
}