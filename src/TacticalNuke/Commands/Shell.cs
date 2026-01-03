using System.CommandLine.Parsing;
using CliWrap;
using Microsoft.Extensions.Logging;
using TacticalNuke.Build;

namespace TacticalNuke.Commands;

[Flags]
public enum CommandLoggingOptions
{
    StandardOutput,
    StandardError
}

public class Shell(
    ILoggerFactory loggerFactory,
    IBuildContext buildContext
)
{
    /// <summary>
    ///     Build a command from the supplied string
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public Command Command(
        string command
    )
    {
        return Command(
            CommandLoggingOptions.StandardError | CommandLoggingOptions.StandardOutput,
            command
        );
    }

    /// <summary>
    ///     Build a command from the supplied string
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public Command Command(
        CommandLoggingOptions loggingOptions,
        string command
    )
    {
        var envVars = new Dictionary<string, string?>();
        string? tool = null;
        var args = "";

        var processedEnvVars = false;
        foreach (var token in CommandLineParser.SplitCommandLine(command))
            if (!processedEnvVars)
            {
                if (token.Contains('='))
                {
                    var split = token.Split('=');
                    envVars[split[0]] = split[1];
                }
                else
                {
                    processedEnvVars = true;
                    tool = token;
                }
            }
            else
            {
                args += $" {token}";
            }

        if (tool is null) throw new ArgumentException($"No tool found in command string: {command}");

        var logger = loggerFactory.CreateLogger(buildContext.ExecutingTarget?.Name ?? "Pipeline");

        // TODO: Need some way to redact sensitive args
        logger.LogInformation(
            $"{{EnvVars}}{tool}{{Args}} @ {{WorkingDirectory}}",
            envVars.StringJoin(p => $"{p.Key}={p.Value}"),
            args,
            buildContext.RootDirectory.FullName
        );

        var cmd = Cli.Wrap(tool)
            .WithWorkingDirectory(buildContext.RootDirectory.FullName)
            .WithEnvironmentVariables(envVars)
            .WithArguments(args)
            .WithValidation(CommandResultValidation.ZeroExitCode);

        if (loggingOptions.HasFlag(CommandLoggingOptions.StandardOutput))
            cmd = cmd.WithStandardOutputPipe(PipeTarget.ToDelegate(line => logger.LogDebug(line)));

        if (loggingOptions.HasFlag(CommandLoggingOptions.StandardError))
            cmd = cmd.WithStandardErrorPipe(PipeTarget.ToDelegate(line =>
            {
                if (line.Contains("warn", StringComparison.InvariantCultureIgnoreCase))
                    logger.LogWarning(line);
                else
                    logger.LogError(line);
            }));

        return cmd;
    }
}