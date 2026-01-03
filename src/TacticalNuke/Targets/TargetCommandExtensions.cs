using TacticalNuke.Commands;

namespace TacticalNuke.Targets;

/// <summary>
///     Builtin execution extensions for <see cref="Target" />
/// </summary>
public static class TargetCommandExtensions
{
    extension<T>(T target) where T : ITarget
    {
        public T Executes(Delegate execution)
        {
            target.Execution = execution;
            return target;
        }

        /// <summary>
        ///     Instructs the <paramref name="target" /> to execute the supplied bash-like <paramref name="command" />
        /// </summary>
        /// <exception cref="ArgumentException">If a tool is not specified</exception>
        public T Executes(
            CommandLoggingOptions loggingOptions,
            params IEnumerable<string> commands
        )
        {
            return target.Executes(async (Shell shell) =>
            {
                foreach (var command in commands) await shell.Command(loggingOptions, command).ExecuteAsync();
            });
        }

        /// <summary>
        ///     Instructs the <paramref name="target" /> to execute the supplied bash-like <paramref name="command" />
        /// </summary>
        /// <exception cref="ArgumentException">If a tool is not specified</exception>
        public T Executes(
            params IEnumerable<string> commands
        )
        {
            return target.Executes(
                CommandLoggingOptions.StandardError | CommandLoggingOptions.StandardOutput,
                commands
            );
        }
    }
}