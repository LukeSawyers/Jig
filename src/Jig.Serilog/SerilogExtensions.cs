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
            [ConsoleThemeStyle.SecondaryText] = "\x1b[37m",   // Gray
            [ConsoleThemeStyle.TertiaryText] = "\x1b[37m",    // Gray

            [ConsoleThemeStyle.Name] = "\x1b[34m",            // Blue
            [ConsoleThemeStyle.Invalid] = "\x1b[31m",         // DarkRed ≈ Red
            [ConsoleThemeStyle.Null] = "\x1b[35m",            // DarkMagenta ≈ Magenta

            [ConsoleThemeStyle.String] = "\x1b[33m",          // DarkYellow ≈ Yellow
            [ConsoleThemeStyle.Number] = "\x1b[33m",
            [ConsoleThemeStyle.Boolean] = "\x1b[33m",
            [ConsoleThemeStyle.Scalar] = "\x1b[33m",

            // Levels
            [ConsoleThemeStyle.LevelVerbose] = "\x1b[38;47m",     // White on Gray
            [ConsoleThemeStyle.LevelDebug] = "\x1b[38;100m",      // White on DarkGray
            [ConsoleThemeStyle.LevelInformation] = "\x1b[38;46m", // White on Cyan
            [ConsoleThemeStyle.LevelWarning] = "\x1b[30;43m",     // Black on Yellow (better contrast)
            [ConsoleThemeStyle.LevelError] = "\x1b[38;41m",       // White on Red
            [ConsoleThemeStyle.LevelFatal] = "\x1b[38;41m",       // White on DarkRed ≈ Red
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
                .MinimumLevel.Verbose()
                .WriteTo.Console(
                    outputTemplate: "[{Level:u3}] {Timestamp:HH:mm:ss} " + $"{{{BuildStateIds.Target}}}" + ": {Message:l}{NewLine}{Exception}",
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