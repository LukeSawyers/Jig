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
        string? tool = null;
        var args = "";

        var processedEnvVars = false;
        foreach (var token in CommandLineParser.SplitCommandLine(command))
        {
            if (!processedEnvVars)
            {
                if (token.Contains('='))
                {
                    var split = token.Split('=');
                    envVars[split[0]] = split[1];
                }
                else
                {
                    processedEnvVars = true;
                    tool = token;
                }
            }
            else
            {
                var t = token;
                if (token.Contains(' '))
                {
                    t = $"\"{token}\"";
                }

                args += $" {t}";
            }
        }

        if (tool is null)
        {
            throw new ArgumentException($"No tool found in command string: {command}");
        }

        return new ShellCommand(envVars, tool, args.Trim());
    }
}