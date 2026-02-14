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
            [ConsoleThemeStyle.SecondaryText] = AnsiTrueColor(Color.Gray), // Gray
            [ConsoleThemeStyle.TertiaryText] = AnsiTrueColor(Color.Gray), // Gray

            [ConsoleThemeStyle.Name] =  AnsiTrueColor(Color.Blue),
            [ConsoleThemeStyle.Invalid] = AnsiTrueColor(Color.DarkRed), 
            [ConsoleThemeStyle.Null] = AnsiTrueColor(Color.DarkMagenta),

            [ConsoleThemeStyle.String] = AnsiTrueColor(Color.FromArgb(161, 121, 19)), 
            [ConsoleThemeStyle.Number] = AnsiTrueColor(Color.FromArgb(161, 121, 19)), 
            [ConsoleThemeStyle.Boolean] = AnsiTrueColor(Color.FromArgb(161, 121, 19)), 
            [ConsoleThemeStyle.Scalar] = AnsiTrueColor(Color.FromArgb(161, 121, 19)), 

            // Levels
            [ConsoleThemeStyle.LevelVerbose] = AnsiTrueColor(Color.White, Color.Gray, bold: true),
            [ConsoleThemeStyle.LevelDebug] = AnsiTrueColor(Color.White, Color.DarkGray, bold: true),
            [ConsoleThemeStyle.LevelInformation] = AnsiTrueColor(Color.White, Color.DarkCyan, bold: true),
            [ConsoleThemeStyle.LevelWarning] = AnsiTrueColor(Color.Black, Color.Orange, bold: true), 
            [ConsoleThemeStyle.LevelError]  = AnsiTrueColor(Color.White, Color.Red, bold: true),
            [ConsoleThemeStyle.LevelFatal] = AnsiTrueColor(Color.White, Color.DarkRed, bold: true),
        });

    private static string AnsiTrueColor(
        Color foreground,
        Color? background = null,
        bool bold = false
    )
    {
        var boldCode = bold ? "1;" : string.Empty;
        var code = $"\x1b[{boldCode}38;2;{foreground.R};{foreground.G};{foreground.B}";

        if (background is { } bg)
        {
            code += $";48;2;{bg.R};{bg.G};{bg.B}";
        }

        code += "m";
        return code;

    }

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