using System.Drawing;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using Jig.Build;
using Jig.Build.Extension.Logging;
using Jig.Logger;

namespace Jig.Serilog;

public static class SerilogExtensions
{
    private static ConsoleTheme DefaultSystemConsoleTheme => new SystemConsoleTheme(
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
                Foreground = ConsoleColor.DarkMagenta
            },
            [ConsoleThemeStyle.String] = new()
            {
                Foreground = ConsoleColor.DarkYellow
            },
            [ConsoleThemeStyle.Number] = new()
            {
                Foreground = ConsoleColor.DarkYellow
            },
            [ConsoleThemeStyle.Boolean] = new()
            {
                Foreground = ConsoleColor.DarkYellow
            },
            [ConsoleThemeStyle.Scalar] = new()
            {
                Foreground = ConsoleColor.DarkYellow
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
                Background = ConsoleColor.DarkCyan
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
            },
        });

    private static ConsoleTheme DefaultAnsiConsoleTheme => new AnsiConsoleTheme(
        new Dictionary<ConsoleThemeStyle, string>
        {
            [ConsoleThemeStyle.Text] = "",
            [ConsoleThemeStyle.SecondaryText] = AnsiConsoleUtils.AnsiTrueColor(Color.Gray), // Gray
            [ConsoleThemeStyle.TertiaryText] = AnsiConsoleUtils.AnsiTrueColor(Color.Gray), // Gray

            [ConsoleThemeStyle.Name] = AnsiConsoleUtils.AnsiTrueColor(Color.Blue),
            [ConsoleThemeStyle.Invalid] = AnsiConsoleUtils.AnsiTrueColor(Color.DarkRed),
            [ConsoleThemeStyle.Null] = AnsiConsoleUtils.AnsiTrueColor(Color.DarkMagenta),

            [ConsoleThemeStyle.String] = AnsiConsoleUtils.AnsiTrueColor(Color.FromArgb(161, 121, 19)),
            [ConsoleThemeStyle.Number] = AnsiConsoleUtils.AnsiTrueColor(Color.FromArgb(161, 121, 19)),
            [ConsoleThemeStyle.Boolean] = AnsiConsoleUtils.AnsiTrueColor(Color.FromArgb(161, 121, 19)),
            [ConsoleThemeStyle.Scalar] = AnsiConsoleUtils.AnsiTrueColor(Color.FromArgb(161, 121, 19)),

            // Levels
            [ConsoleThemeStyle.LevelVerbose] = AnsiConsoleUtils.AnsiTrueColor(Color.White, Color.Gray, bold: true),
            [ConsoleThemeStyle.LevelDebug] = AnsiConsoleUtils.AnsiTrueColor(Color.White, Color.DarkGray, bold: true),
            [ConsoleThemeStyle.LevelInformation] = AnsiConsoleUtils.AnsiTrueColor(Color.White, Color.DarkCyan, bold: true),
            [ConsoleThemeStyle.LevelWarning] = AnsiConsoleUtils.AnsiTrueColor(Color.Black, Color.Orange, bold: true),
            [ConsoleThemeStyle.LevelError] = AnsiConsoleUtils.AnsiTrueColor(Color.White, Color.Red, bold: true),
            [ConsoleThemeStyle.LevelFatal] = AnsiConsoleUtils.AnsiTrueColor(Color.White, Color.DarkRed, bold: true),
        });

    extension<T>(T build) where T : IBuild
    {
        /// <summary>
        ///     Add serilog logging to the build 
        /// </summary>
        /// <param name="configure"></param>
        /// <returns></returns>
        public T AddSerilog(Func<LoggerConfiguration, LoggerConfiguration>? configure = null)
        {
            var configuration = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .Enrich.With(new AnsiParameterColorer([BuildStateIds.Target]))
                .MinimumLevel.Verbose()
                .WriteTo.Console(
                    outputTemplate: "[{Level:u3}] {Timestamp:HH:mm:ss} " + $"{{{BuildStateIds.Target}}}" +
                                    ": {Message:l}{NewLine}{Exception}",
                    theme: DefaultAnsiConsoleTheme,
                    applyThemeToRedirectedOutput: true
                );

            if (configure != null)
            {
                configuration = configure(configuration);
            }

            Log.Logger = configuration.CreateLogger();

            build.Services.AddLogging(b => b.AddSerilog(Log.Logger));
            build.AddDefaultLoggingExtensions();

            return build;
        }
    }
}