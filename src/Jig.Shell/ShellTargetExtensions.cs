using CliWrap;
using Jig.Lang;
using Jig.Targets;
using Newtonsoft.Json;

namespace Jig.Shell;

public static class ShellTargetExtensions
{
    extension(ITarget target)
    {
        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="command" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public ITarget ExecutesDotNetToolWithJsonOutput<TOutput>(
            FormattableString command,
            JsonSerializerSettings? serializerSettings = null,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        )
        {
            var description = command.ToDotnetToolCommand().Sanitize().Concat($" : {typeof(TOutput).Name}");

            return target.Executes(async (Shell shell, CancellationToken stoppingToken) => await shell
                    .DotnetToolCommand(command, validation, logging)
                    .ExecuteAndCaptureJsonOutputAsync<TOutput>(serializerSettings ?? new JsonSerializerSettings(), stoppingToken),
                description
            );
        }
    }

    extension<T>(T target) where T : ITarget
    {
        /// <summary>
        ///     Instructs the <paramref name="target" /> to execute the supplied bash-like <paramref name="command" />
        /// </summary>
        /// <exception cref="ArgumentException">If a tool is not specified</exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        public T Executes(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        )
        {
            target.Executions.Add(new TargetExecution(
                async Task (Shell shell) => await shell
                    .Command(command, validation, logging)
                    .ExecuteAsync(),
                command.Sanitize().Redact().ToPrintableCommandString()
            ));

            return target;
        }

        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="command" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public T ExecutesDotNetTool(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            command.ToDotnetToolCommand(),
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="command" /> in the platform's native shell
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotSupportedException">If the current platform isn't supported</exception>
        public T ExecutesDefaultShell(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            command.ToNativeShellCommand(),
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="command" /> in bash
        /// </summary>
        /// <returns></returns>
        public T ExecutesBash(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            command.ToBashCommand(),
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="command" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesZsh(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            command.ToZshCommand(),
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="command" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesDash(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            command.ToDashCommand(),
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="command" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesAsh(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            command.ToAshCommand(),
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="command" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesPowershell(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            command.ToPowerShellCommand(),
            validation,
            logging
        );
    }
}