using xBuild.Targets;

namespace xBuild.Shell;

public static class ShellTargetExtensions
{
    extension<T>(T target) where T : ITarget
    {
        /// <summary>
        ///     Instructs the <paramref name="target" /> to execute the supplied bash-like <paramref name="command" />
        /// </summary>
        /// <exception cref="ArgumentException">If a tool is not specified</exception>
        public T Executes(
            FormattableString command,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes([command], loggingOptions);

        /// <summary>
        ///     Instructs the <paramref name="target" /> to execute the supplied bash-like <paramref name="commands" />
        /// </summary>
        /// <exception cref="ArgumentException">If a tool is not specified</exception>
        public T Executes(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(async (TargetShell shell) =>
        {
            foreach (var command in commands)
            {
                await shell.Command(command, loggingOptions).ExecuteAsync();
            }
        });

        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="commands" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public T ExecutesDotNetTool(
            IEnumerable<FormattableString> commands,
            ShellLoggingOptions? loggingOptions = null
        ) => target.Executes(
            commands.Select(ShellExtensions.ToDotnetToolCommand),
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
    }
}