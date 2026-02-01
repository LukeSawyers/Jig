using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using xBuild.Build;
using xBuild.Build.Extension.Logging;
using xBuild.Logger;

namespace xBuild.Serilog;

public static class SerilogExtensions
{
    private static ConsoleTheme DefaultSystemColorTheme => new SystemConsoleTheme(
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
                    theme: DefaultSystemColorTheme,
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