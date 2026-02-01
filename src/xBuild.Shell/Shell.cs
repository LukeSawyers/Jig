using CliWrap;
using Microsoft.Extensions.Logging;

namespace xBuild.Shell;

public class Shell(ILogger<Shell> logger)
{
    /// <summary>
    ///     Build a command from the supplied string
    /// </summary>
    /// <param name="command">The command to execute</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public Command Command(
        FormattableString command,
        CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
        ShellLoggingOptions? logging = null
    )
    {
        command = command.Sanitize();
        var redacted = command.Redact();
        logger.LogInformation(redacted.Format, redacted.GetArguments());

        var shellCommand = ShellCommand.Parse(command.ToString());

        var cmd = Cli.Wrap(shellCommand.Tool)
            .WithArguments(shellCommand.Args)
            .WithWorkingDirectory(Directory.GetCurrentDirectory())
            .WithEnvironmentVariables(shellCommand.EnvironmentVariables)
            .WithValidation(validation);

        logging ??= ShellLoggingOptions.StandardOutput | ShellLoggingOptions.StandardError;

        if (logging.Value.HasFlag(ShellLoggingOptions.StandardOutput))
        {
            cmd = cmd.WithStandardOutputPipe(PipeTarget.ToDelegate(line =>
            {
                if (line.Contains("warn", StringComparison.InvariantCultureIgnoreCase))
                {
                    logger.LogWarning(line);
                }
                else if (line.Contains("error", StringComparison.InvariantCultureIgnoreCase))
                {
                    logger.LogError(line);
                }
                else
                {
                    logger.LogDebug(line);
                }
            }));
        }

        if (logging.Value.HasFlag(ShellLoggingOptions.StandardError))
        {
            cmd = cmd.WithStandardErrorPipe(PipeTarget.ToDelegate(line =>
            {
                if (line.Contains("warn", StringComparison.InvariantCultureIgnoreCase))
                {
                    logger.LogWarning(line);
                }
                else
                {
                    logger.LogError(line);
                }
            }));
        }

        return cmd;
    }
}