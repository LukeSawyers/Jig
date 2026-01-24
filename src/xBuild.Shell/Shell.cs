using System.Runtime.CompilerServices;
using CliWrap;
using xBuild.Logging;
using xBuild.Options;

namespace xBuild.Shell;

public abstract class Shell(IBaseLogger logger)
{
    /// <summary>
    ///     Build a command from the supplied string
    /// </summary>
    /// <param name="command">The command to execute</param>
    /// <param name="executeMode">
    /// The execute mode to use
    /// Defaults to the mode confiured in the shell if not specified
    /// </param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public Command Command(
        FormattableString command,
        ShellLoggingOptions? loggingOptions = null
    )
    {
        var sanitizedCommand = FormattableStringFactory.Create(
            command.Format
                .Replace(" \r\n ", " ")
                .Replace(" \n ", " ")
                .Replace(" \r ", " ")
                .Replace("\r\n ", " ")
                .Replace("\n ", " ")
                .Replace("\r ", " ")
                .Replace(" \r\n", " ")
                .Replace(" \n", " ")
                .Replace(" \r", " ")
                .Replace("\r\n", " ")
                .Replace("\n", " ")
                .Replace("\r", " "),
            command.GetArguments()
        );

        LogCommand(sanitizedCommand);

        var shellCommand = ShellCommand.Parse(sanitizedCommand.ToString());

        var cmd = Cli.Wrap(shellCommand.Tool)
            .WithArguments(shellCommand.Args)
            .WithWorkingDirectory(Directory.GetCurrentDirectory())
            .WithEnvironmentVariables(shellCommand.EnvironmentVariables)
            .WithValidation(CommandResultValidation.ZeroExitCode);

        loggingOptions ??= ShellLoggingOptions.StandardOutput | ShellLoggingOptions.StandardError;

        if (loggingOptions.Value.HasFlag(ShellLoggingOptions.StandardOutput))
        {
            cmd = cmd.WithStandardOutputPipe(PipeTarget.ToDelegate(s => logger.LogOutputFormat(s)));
        }

        if (loggingOptions.Value.HasFlag(ShellLoggingOptions.StandardError))
        {
            cmd = cmd.WithStandardErrorPipe(PipeTarget.ToDelegate(line =>
            {
                if (line.Contains("warn", StringComparison.InvariantCultureIgnoreCase))
                {
                    logger.LogWarningFormat(line);
                }
                else
                {
                    logger.LogErrorFormat(line);
                }
            }));
        }

        return cmd;
    }

    private void LogCommand(FormattableString command)
    {
        const string redactedString = "[REDACTED]";
        var format = command.Format;
        var arguments = command.GetArguments();
        for (var i = 0; i < arguments.Length; i++)
        {
            var argument = arguments[i];
            if (argument is IBuildOption option)
            {
                arguments[i] = option.Sensitive ? redactedString : option.RawValue;
            }
            else
            {
                format = format.Replace($"{{{i}:redact}}", redactedString);
            }
        }

        format = format.Replace('\r', ' ');
        format = format.Replace('\n', ' ');
        var logCommandString = string.Format(format, arguments);

        logger.LogInformationFormat(
            $"{logCommandString} @ {Directory.GetCurrentDirectory()}"
        );
    }
}