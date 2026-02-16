using System.CommandLine.Parsing;

namespace Jig.Shell;

public record ShellCommand(
    Dictionary<string, string> EnvironmentVariables,
    string Tool,
    string Args
)
{
    /// <summary>
    ///     Parse the supplied command string
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">If there is a problem parsing the command</exception>
    public static ShellCommand Parse(string command)
    {
        var envVars = new Dictionary<string, string?>();

        foreach (var token in CommandLineParser.SplitCommandLine(command))
        {
            if (token.Contains('='))
            {
                var split = token.Split('=');
                envVars[split[0]] = split[1];
                command = command.Replace(token, "");
            }
            else
            {
                var args = command.Substring(command.IndexOf(token) + token.Length);
                return new ShellCommand(envVars, token, args.Trim());
            }
        }
        
        throw new ArgumentException($"No tool found in command string: {command}");
    }
}