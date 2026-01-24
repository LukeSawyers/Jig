using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using CliWrap;
using DotNetEnv;
using xBuild.Targets;

namespace xBuild.Shell;

public static class ShellExtensions
{
    extension<T>(T target) where T : ITarget
    {
        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="commands" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public T ExecutesDotNetTool(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(
            commands.Select(ToDotnetToolCommand),
            loggingOptions
        );

        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="commands" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public T ExecutesDotNetTool(
            FormattableString commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            [commands],
            loggingOptions
        );
        
        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in the platform's native shell
        /// </summary>
        /// <returns></returns>
        public T ExecutesNativeShell(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(
            commands.Select(ToNativeShellCommand),
            loggingOptions
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in the platform's native shell
        /// </summary>
        /// <returns></returns>
        public T ExecutesDefaultShell(
            FormattableString commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesNativeShell(
            [commands],
            loggingOptions
        );
        
        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in bash
        /// </summary>
        /// <returns></returns>
        public T ExecutesBash(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(
            commands.Select(ToBashCommand),
            loggingOptions
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in bash
        /// </summary>
        /// <returns></returns>
        public T ExecutesBash(
            FormattableString commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesBash(
            [commands],
            loggingOptions
        );
        
        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesZsh(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(
            commands.Select(ToZshCommand),
            loggingOptions
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesZsh(
            FormattableString commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesZsh(
            [commands],
            loggingOptions
        );
        
        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesDash(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(
            commands.Select(ToDashCommand),
            loggingOptions
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesDash(
            FormattableString commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDash(
            [commands],
            loggingOptions
        );
        
        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesAsh(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(
            commands.Select(ToAshCommand),
            loggingOptions
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesAsh(
            FormattableString commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesAsh(
            [commands],
            loggingOptions
        );
        
        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesPowershell(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(
            commands.Select(ToPowershellCommand),
            loggingOptions
        );

        /// <summary>
        ///     Adds an execution running the specified <paramref name="commands" /> in zsh
        /// </summary>
        /// <returns></returns>
        public T ExecutesPowershell(
            FormattableString commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesPowershell(
            [commands],
            loggingOptions
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
            ShellLoggingOptions? loggingOptions = null
        ) => shell.Command(ToDotnetToolCommand(command), loggingOptions);

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
            ShellLoggingOptions? loggingOptions = null
        ) => shell.Command(ToNativeShellCommand(command), loggingOptions);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in bash.
        /// </summary>
        public Command BashCommand(
            FormattableString command,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.Command(ToBashCommand(command), loggingOptions);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in zsh.
        /// </summary>
        public Command ZshCommand(
            FormattableString command,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.Command(ToZshCommand(command), loggingOptions);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in ash.
        /// </summary>
        public Command AshCommand(
            FormattableString command,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.Command(ToAshCommand(command), loggingOptions);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in dash/sh.
        /// </summary>
        public Command DashCommand(
            FormattableString command,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.Command(ToDashCommand(command), loggingOptions);

        /// <summary>
        /// Builds a <see cref="Command"/> for running the specified <paramref name="command"/> in powershell.
        /// </summary>
        public Command PowershellCommand(
            FormattableString command,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.Command(ToPowershellCommand(command), loggingOptions);
    }

    public static FormattableString ToDotnetToolCommand(FormattableString command)
    {
        var tool = ShellCommand.Parse(command.ToString()).Tool;
        return FormattableStringFactory.Create(
            command.Format.Replace(tool, $"dotnet tool exec -y --allow-roll-forward --ignore-failed-sources {tool} --"),
            command.GetArguments()
        );
    }

    public static FormattableString ToBashCommand(FormattableString command) => ToPosixShellCommand("bash", command);

    public static FormattableString ToZshCommand(FormattableString command) => ToPosixShellCommand("zsh", command);
    
    public static FormattableString ToAshCommand(FormattableString command) => ToPosixShellCommand("ash", command);
    
    public static FormattableString ToDashCommand(FormattableString command) => ToPosixShellCommand("sh", command);

    public static FormattableString ToPosixShellCommand(string shell, FormattableString command)
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

    public static FormattableString ToPowershellCommand(FormattableString command)
    {
        var envVarStrings = ShellCommand.Parse(command.ToString()).EnvironmentVariables
            .Select(e => $"{e.Key}={e.Value}")
            .ToArray();

        var strippedCommandFormat = envVarStrings
            .Aggregate(command.Format, (current, envVarString) => current.Replace(envVarString, ""))
            .Replace("\"", "\\\"");

        var joinedEnvStrings = envVarStrings.StringJoin(" ");

        var powershellPath = GetPowershellPath();

        var format = $"{joinedEnvStrings} {powershellPath} -NoProfile -Command \"{strippedCommandFormat}\"";

        return FormattableStringFactory.Create(
            format,
            command.GetArguments()
        );
    }

    private static string GetPowershellPath() => OperatingSystem.IsWindows() ? "powershell" : "/usr/bin/pwsh";

    /// <exception cref="NotSupportedException"></exception>
    private static FormattableString ToNativeShellCommand(FormattableString command)
    {
        if (OperatingSystem.IsWindows())
        {
            return ToPowershellCommand(command);
        }

        var defaultShell = Environment.GetEnvironmentVariable("SHELL");

        if (defaultShell?.EndsWith("bash") == true)
        {
            return ToBashCommand(command);
        }

        if (defaultShell?.EndsWith("zsh") == true)
        {
            return ToZshCommand(command);
        }

        if (defaultShell?.EndsWith("sh") == true)
        {
            return ToDashCommand(command);
        }

        if (OperatingSystem.IsLinux())
        {
            return ToBashCommand(command);
        }

        // MacOS Catalina+ defaults to Zsh
        if (OperatingSystem.IsMacOSVersionAtLeast(10, 15))
        {
            return ToPowershellCommand(command);
        }

        if (OperatingSystem.IsMacOS())
        {
            return ToBashCommand(command);
        }

        throw new NotSupportedException($"{Environment.OSVersion.Platform} not supported");
    }
}