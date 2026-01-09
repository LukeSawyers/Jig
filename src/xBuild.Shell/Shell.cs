using CliWrap;
using xBuild.Logging;
using xBuild.Options;

namespace xBuild.Shell;

public abstract class Shell(IBaseLogger logger)
{
    /// <summary>
    ///     Build a command from the supplied string
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public Command Command(
        FormattableString command,
        ShellLoggingOptions? loggingOptions = null
    )
    {
        loggingOptions ??= ShellLoggingOptions.StandardOutput | ShellLoggingOptions.StandardError;
        var shellCommand = ShellCommand.Parse(command.ToString());
        LogCommand(command);

        var cmd = Cli.Wrap("/bin/bash")
            .WithWorkingDirectory(Directory.GetCurrentDirectory())
            .WithEnvironmentVariables(shellCommand.EnvironmentVariables)
            .WithArguments($"-lc \"{shellCommand.Tool} {shellCommand.Args.Replace("\"", "\\\"")}\"")
            .WithValidation(CommandResultValidation.ZeroExitCode);

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