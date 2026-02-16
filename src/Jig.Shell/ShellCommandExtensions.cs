using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Channels;
using CliWrap;
using Newtonsoft.Json;
using Jig.Lang;
using Jig.Options;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Jig.Shell;

public static class ShellCommandExtensions
{
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
            var arguments = new object?[command.ArgumentCount];
            command.GetArguments().CopyTo(arguments);
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

            return FormattableStringFactory.Create(format, arguments);
        }

        public FormattableString ToPrintableCommandString()
        {
            var format = command.Format;

            var shellCommand = ShellCommand.Parse(command.ToString());

            format = format.Replace(shellCommand.Tool, "{Tool}");
            format += " @ {CurrentDirectory}";

            var arguments = new[]
                {
                    shellCommand.Tool
                }
                .Concat(command.GetArguments())
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
        public FormattableString ToBashCommand() => command.ToUnixShellCommand("bash");

        /// <summary>
        ///     Wraps this command to be executed in zsh shell
        /// </summary>
        public FormattableString ToZshCommand() => command.ToUnixShellCommand("zsh");

        /// <summary>
        ///     Wraps this command to be executed in busybox shell
        /// </summary>
        public FormattableString ToAshCommand() => command.ToUnixShellCommand("ash");

        /// <summary>
        ///     Wraps this command to be executed in dash/sh shell
        /// </summary>
        public FormattableString ToDashCommand() => command.ToUnixShellCommand("sh");

        /// <summary>
        ///     Wraps this command to be executed in the specified posix-style <paramref name="shell"/>
        /// </summary>
        public FormattableString ToUnixShellCommand(string shell)
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
        public FormattableString ToNativeShellCommand()
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

            if (!string.IsNullOrWhiteSpace(defaultShell))
            {
                return command.ToUnixShellCommand(defaultShell);
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

    extension(Command command)
    {
        /// <summary>
        ///     Execute the command returning each standard output line as an async enumerable.
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        public async IAsyncEnumerable<string> ExecuteAndCaptureOutputAsync(CancellationToken stoppingToken)
        {
            var output = Channel.CreateUnbounded<string>();
            var commandExecution = command
                .WithStandardOutputPipe(PipeTarget.ToDelegate(async line =>
                    await output.Writer.WriteAsync(line, stoppingToken)))
                .ExecuteAsync(stoppingToken);

            var completeTask = commandExecution.Task.ContinueWith(_ => output.Writer.Complete(), stoppingToken);

            await foreach (var line in output.Reader.ReadAllAsync(stoppingToken))
            {
                yield return line;
            }

            await completeTask;
        }

        /// <summary>
        ///     Execute the command returning each standard output line as an async enumerable.
        /// </summary>
        /// <param name="settings">Settings to use when deserializing</param>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        public ValueTask<T?> ExecuteAndCaptureJsonOutputAsync<T>(
            JsonSerializerSettings? settings = null,
            CancellationToken stoppingToken = default
        ) => command
            .ExecuteAndCaptureOutputAsync(stoppingToken)
            .ToArrayAsync(cancellationToken: stoppingToken)
            .LetAsync(lines => JsonConvert.DeserializeObject<T>(lines.StringJoin(Environment.NewLine), settings));

        /// <summary>
        ///     Execute the command returning each standard output line as an async enumerable.
        /// </summary>
        /// <param name="options">Options to use when deserializing</param>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        public ValueTask<T?> ExecuteAndCaptureJsonOutputAsync<T>(
            JsonSerializerOptions? options = null,
            CancellationToken stoppingToken = default
        ) => command
            .ExecuteAndCaptureOutputAsync(stoppingToken)
            .ToArrayAsync(cancellationToken: stoppingToken)
            .LetAsync(lines => JsonSerializer.Deserialize<T>(lines.StringJoin(Environment.NewLine), options));
    }
}