using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static class ShellTargetExtensions
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
            commands.Select(ShellExtensions.ToDotnetToolCommand),
            loggingOptions
        );

        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="command" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public T ExecutesDotNetTool(
            FormattableString command,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            [command],
            loggingOptions
        );
    }
}