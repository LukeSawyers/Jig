using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using CliWrap;
using xBuild.Targets;

namespace xBuild.Shell;

public static class ShellExtensions
{
    extension(ITarget target)
    {
        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="command" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public ITarget ExecutesDotNetToolWithJsonOutput<TOutput>(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(async (TargetShell shell, CancellationToken stoppingToken) => await shell
            .DotnetToolCommand(command, validation, logging)
            .ExecuteAndCaptureJsonOutputAsync<TOutput>(stoppingToken));
    }

    extension<T>(T target) where T : ITarget
    {
        /// <summary>
        ///     Instructs the <paramref name="target" /> to execute the supplied bash-like <paramref name="command" />
        /// </summary>
        /// <exception cref="ArgumentException">If a tool is not specified</exception>
        public T Executes(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes([command], validation, logging);

        /// <summary>
        ///     Instructs the <paramref name="target" /> to execute the supplied bash-like <paramref name="commands" />
        /// </summary>
        /// <exception cref="ArgumentException">If a tool is not specified</exception>
        public T Executes(
            IEnumerable<FormattableString> commands,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(async (TargetShell shell) =>
        {
            foreach (var command in commands)
            {
                await shell.Command(command, validation, logging).ExecuteAsync();
            }
        });

        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="commands" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public T ExecutesDotNetTool(
            IEnumerable<FormattableString> commands,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            commands.Select(ToDotnetToolCommand),
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="command" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public T ExecutesDotNetTool(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.ExecutesDotNetTool(
            [command],
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in the platform's native shell
        /// </summary>
        /// <returns></returns>
        public T ExecutesNativeShell(
            IEnumerable<FormattableString> commands,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            commands.Select(ToNativeShellCommand),
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="command" /> in the platform's native shell
        /// </summary>
        /// <returns></returns>
        public T ExecutesDefaultShell(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.ExecutesNativeShell(
            [command],
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in bash
        /// </summary>
        /// <returns></returns>
        public T ExecutesBash(
            IEnumerable<FormattableString> commands,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            commands.Select(ToBashCommand),
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
        ) => target.ExecutesBash(
            [command],
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesZsh(
            IEnumerable<FormattableString> commands,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            commands.Select(ToZshCommand),
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
        ) => target.ExecutesZsh(
            [command],
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesDash(
            IEnumerable<FormattableString> commands,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            commands.Select(ToDashCommand),
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
        ) => target.ExecutesDash(
            [command],
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesAsh(
            IEnumerable<FormattableString> commands,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            commands.Select(ToAshCommand),
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
        ) => target.ExecutesAsh(
            [command],
            validation,
            logging
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesPowershell(
            IEnumerable<FormattableString> commands,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => target.Executes(
            commands.Select(ToPowershellCommand),
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
        ) => target.ExecutesPowershell(
            [command],
            validation,
            logging
        );
    }

    extension(Shell shell)
    {
        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified dotnet tool in <paramref name="command"/> using dotnet exec
        /// </summary>
        /// <returns></returns>
        public Command DotnetToolCommand(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => shell.Command(command.ToDotnetToolCommand(), validation, logging);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> using the default OS shell:
        ///  - Windows: Powershell
        ///  - Linux: Value of $SHELL environment variable, fall back to /bin/bash
        ///  - MacOS: Value of $SHELL environment variable, fall back to /bin/zsh
        /// </summary>
        /// <exception cref="NotSupportedException">If the current platform is not supported</exception>
        [SupportedOSPlatform("windows")]
        [SupportedOSPlatform("linux")]
        [SupportedOSPlatform("macos")]
        public Command NativeShellCommand(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => shell.Command(command.ToNativeShellCommand(), validation, logging);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in bash.
        /// </summary>
        public Command BashCommand(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => shell.Command(command.ToBashCommand(), validation, logging);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in zsh.
        /// </summary>
        public Command ZshCommand(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => shell.Command(command.ToZshCommand(), validation, logging);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in ash.
        /// </summary>
        public Command AshCommand(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => shell.Command(command.ToAshCommand(), validation, logging);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in dash/sh.
        /// </summary>
        public Command DashCommand(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => shell.Command(command.ToDashCommand(), validation, logging);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in powershell.
        /// </summary>
        public Command PowershellCommand(
            FormattableString command,
            CommandResultValidation validation = CommandResultValidation.ZeroExitCode,
            ShellLoggingOptions? logging = null
        ) => shell.Command(command.ToPowershellCommand(), validation, logging);
    }

    extension(FormattableString command)
    {
        public FormattableString ToDotnetToolCommand()
        {
            var tool = ShellCommand.Parse(command.ToString()).Tool;
            return FormattableStringFactory.Create(
                command.Format.Replace(tool, $"dotnet tool exec -y --allow-roll-forward --ignore-failed-sources {tool} --"),
                command.GetArguments()
            );
        }

        public FormattableString ToBashCommand() => command.ToPosixShellCommand("bash");

        public FormattableString ToZshCommand() => command.ToPosixShellCommand("zsh");

        public FormattableString ToAshCommand() => command.ToPosixShellCommand("ash");

        public FormattableString ToDashCommand() => command.ToPosixShellCommand("sh");

        public FormattableString ToPosixShellCommand(string shell)
        {
            var envVarStrings = ShellCommand.Parse(command.ToString()).EnvironmentVariables
                .Select(e => $"{e.Key}={e.Value}")
                .ToArray();

            var strippedCommandFormat = envVarStrings
                .Aggregate(command.Format, (current, envVarString) => current.Replace(envVarString, ""))
                .Replace("\"", "\\\"");

            var joinedEnvStrings = envVarStrings.StringJoin(" ");

            var format = $"{joinedEnvStrings} /bin/{shell} -lc \"{strippedCommandFormat}\"";

            return FormattableStringFactory.Create(
                format,
                command.GetArguments()
            );
        }

        public FormattableString ToPowershellCommand()
        {
            var envVarStrings = ShellCommand.Parse(command.ToString()).EnvironmentVariables
                .Select(e => $"{e.Key}={e.Value}")
                .ToArray();

            var strippedCommandFormat = envVarStrings
                .Aggregate(command.Format, (current, envVarString) => current.Replace(envVarString, ""))
                .Replace("\"", "\\\"");

            var joinedEnvStrings = envVarStrings.StringJoin(" ");

            var powershellPath = OperatingSystem.IsWindows() ? "powershell" : "/usr/bin/pwsh";

            var format = $"{joinedEnvStrings} {powershellPath} -NoProfile -Command \"{strippedCommandFormat}\"";

            return FormattableStringFactory.Create(
                format,
                command.GetArguments()
            );
        }

        /// <exception cref="NotSupportedException"></exception>
        private FormattableString ToNativeShellCommand()
        {
            if (OperatingSystem.IsWindows())
            {
                return command.ToPowershellCommand();
            }

            var defaultShell = Environment.GetEnvironmentVariable("SHELL");

            if (defaultShell?.EndsWith("bash") == true)
            {
                return command.ToBashCommand();
            }

            if (defaultShell?.EndsWith("zsh") == true)
            {
                return command.ToZshCommand();
            }

            if (defaultShell?.EndsWith("sh") == true)
            {
                return command.ToDashCommand();
            }

            if (OperatingSystem.IsLinux())
            {
                return command.ToBashCommand();
            }

            // MacOS Catalina+ defaults to Zsh
            if (OperatingSystem.IsMacOSVersionAtLeast(10, 15))
            {
                return command.ToPowershellCommand();
            }

            if (OperatingSystem.IsMacOS())
            {
                return command.ToBashCommand();
            }

            throw new NotSupportedException($"{Environment.OSVersion.Platform} not supported");
        }
    }
}