using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static class ShellExtensions
{
    public static FormattableString ToDotnetToolCommand(FormattableString command)
    {
        var tool = ShellCommand.Parse(command.ToString()).Tool;
        return FormattableStringFactory.Create(
            command.Format.Replace(tool, $"dotnet tool exec -y --allow-roll-forward --ignore-failed-sources {tool} --"),
            command.GetArguments()
        );
    }

    extension(Shell shell)
    {
        public Command DotnetToolCommand(
            FormattableString command,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.Command(ToDotnetToolCommand(command), loggingOptions);
    }
}