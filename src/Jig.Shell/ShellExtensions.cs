using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using CliWrap;
using Newtonsoft.Json;
using Jig.Lang;
using Jig.Options;
using Jig.Targets;

namespace Jig.Shell;

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
                command.Sanitize().Redact()
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
        ) => shell.Command(command.ToPowerShellCommand(), validation, logging);
    }

    extension(FormattableString command)
    {
        /// <summary>
        ///     Normalizes whitespace in command strings 
        /// </summary>
        public FormattableString Sanitize() => FormattableStringFactory.Create(
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

        /// <summary>
        ///     Redacts sensitive <see cref="IBuildOption"/> arguments and arguments with :redact formatting
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        public FormattableString Redact()
        {
            const string redactedString = "[REDACTED]";
            var format = command.Format;
            var arguments = command.GetArguments();
            for (var i = 0; i < arguments.LongLength; i++)
            {
                var argument = arguments[i];
                if (argument is IBuildOption option)
                {
                    arguments[i] = option.Sensitive ? redactedString : option.RawValue;
                }
                else if (format.Contains($"{{{i}:redact}}"))
                {
                    arguments[i] = redactedString;
                }
            }

            var shellCommand = ShellCommand.Parse(command.ToString());

            format = format.Replace(shellCommand.Tool, "{Tool}");
            format += " @ {CurrentDirectory}";

            arguments = new[]
                {
                    shellCommand.Tool
                }
                .Concat(arguments)
                .Append(Directory.GetCurrentDirectory())
                .ToArray();
            
            return FormattableStringFactory.Create(format, arguments);
        }

        /// <summary>
        ///     Converts the supplied command, assumed to be a dotnet tool invocation, into the command required to run that tool.
        /// </summary>
        /// <returns></returns>
        public FormattableString ToDotnetToolCommand()
        {
            var tool = ShellCommand.Parse(command.ToString()).Tool;
            return FormattableStringFactory.Create(
                command.Format.Replace(tool, $"dotnet tool exec -y --allow-roll-forward --ignore-failed-sources {tool} --"),
                command.GetArguments()
            );
        }

        /// <summary>
        ///     Wraps this command to be executed in bash shell
        /// </summary>
        public FormattableString ToBashCommand() => command.ToPosixShellCommand("bash");

        /// <summary>
        ///     Wraps this command to be executed in zsh shell
        /// </summary>
        public FormattableString ToZshCommand() => command.ToPosixShellCommand("zsh");

        /// <summary>
        ///     Wraps this command to be executed in busybox shell
        /// </summary>
        public FormattableString ToAshCommand() => command.ToPosixShellCommand("ash");

        /// <summary>
        ///     Wraps this command to be executed in dash/sh shell
        /// </summary>
        public FormattableString ToDashCommand() => command.ToPosixShellCommand("sh");

        /// <summary>
        ///     Wraps this command to be executed in the specified posix-style <paramref name="shell"/>
        /// </summary>
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

        /// <summary>
        ///     Wraps this command to be executed in powershell
        /// </summary>
        public FormattableString ToPowerShellCommand()
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
                return command.ToPowerShellCommand();
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
                return command.ToPowerShellCommand();
            }

            if (OperatingSystem.IsMacOS())
            {
                return command.ToBashCommand();
            }

            throw new NotSupportedException($"{Environment.OSVersion.Platform} not supported");
        }
    }
}