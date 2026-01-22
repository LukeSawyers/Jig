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
    }
}

