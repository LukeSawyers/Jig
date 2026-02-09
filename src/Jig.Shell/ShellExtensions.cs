using System.Runtime.Versioning;
using CliWrap;

namespace Jig.Shell;

public static class ShellExtensions
{
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
}