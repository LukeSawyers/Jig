using Humanizer;
using xBuild.Logging;
using xBuild.Shell;
using xBuild.Targets;

namespace _build.Targets;

public class DotnetToolsGeneration : ITargetProvider
{
    private const string TargetExtensionClassName = "DotnetToolsTargetExtensions";
    private const string ShellExtensionClassName = "DotnetToolsShellExtensions";

    record ToolData(
        string ToolName,
        string MethodName
    );

    private string ProjectDirectory => Path.Combine(Directory.GetCurrentDirectory(), "xBuild.Shell.DotnetTools");

    public ITarget GenerateDotNetToolsExtensions => field ??= new Target(
        description: "Generates content of xBuild.Shell.DotnetTools"
    ).Executes(async (ITargetLogger logger, TargetShell shell, CancellationToken stoppingToken) =>
    {
        var tools = await GetToolsAsync(logger, shell, stoppingToken);
        await ClearGeneratedFiles();
        await WriteTargetExtensionsAsync(tools);
        await WriteShellExtensionsAsync(tools);
    });

    private static async Task<IEnumerable<ToolData>> GetToolsAsync(
        ITargetLogger logger,
        TargetShell shell,
        CancellationToken stoppingToken
    )
    {
        var chars = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i);

        var results = new Dictionary<string, ToolData>();
        foreach (var ch in chars)
        {
            var skip = 0;
            const int take = 1000;
            while (!stoppingToken.IsCancellationRequested)
            {
                var tools = await shell
                    .Command($"dotnet tool search {ch} --skip {skip} --take {take}")
                    .ExecuteAndCaptureOutputAsync(stoppingToken)
                    .Skip(2)
                    .Select(line => line.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[0])
                    .ToArrayAsync(stoppingToken);

                foreach (var tool in tools)
                {
                    if (char.IsDigit(tool[0]))
                    {
                        continue;
                    }

                    var methodName = tool.Replace('.', '-').Pascalize().Replace("-", "");
                    results[methodName] = new ToolData(
                        tool,
                        methodName
                    );
                }

                // If we've reached the end of the search, break the loop
                if (tools.Length != take)
                {
                    break;
                }

                skip += take;
            }
        }

        logger.LogInformation($"Found {results.Count} tools");
        return results.Values;
    }

    private async Task ClearGeneratedFiles()
    {
        var directory = new DirectoryInfo(ProjectDirectory);

        var files = directory
            .EnumerateFiles($"{TargetExtensionClassName}_*.cs")
            .Concat(directory.EnumerateFiles($"{ShellExtensionClassName}_*.cs"))
            .ToArray();
        
        foreach (var file in files)
        {
            file.Delete();
        }
    }

    private async Task WriteTargetExtensionsAsync(IEnumerable<ToolData> results)
    {
        var groups = results
            .Chunk(100)
            .ToArray();

        const string header =
            $$"""
              using System.Runtime.CompilerServices;
              using xBuild.Targets;
              
              namespace xBuild.Shell.DotnetTools;

              public static partial class {{TargetExtensionClassName}}
              {
                 extension<T>(T target) where T : ITarget
                 {
              """;

        const string footer =
            """
                }
            }
            """;

        for (var index = 0; index < groups.Length; index++)
        {
            var group = groups[index];
            var methods = group
                .Select(tool =>
                    $$"""
                      
                              public T {{tool.MethodName}}(
                                  FormattableString arguments,
                                  ShellLoggingOptions? loggingOptions = null
                              ) => target.ExecutesDotNetTool(
                                  FormattableStringFactory.Create($"{{tool.ToolName}} {arguments.Format}", arguments.GetArguments()),
                                  loggingOptions
                              );

                      """
                ).ToArray();

            var filePath = Path.Combine(ProjectDirectory, $"{TargetExtensionClassName}_{index}.cs");

            await using var writer = new StreamWriter(File.Create(filePath));

            await writer.WriteAsync(header);

            foreach (var method in methods)
            {
                await writer.WriteAsync(method);
            }

            await writer.WriteAsync(footer);
        }
    }

    private async Task WriteShellExtensionsAsync(IEnumerable<ToolData> results)
    {
        var groups = results
            .Chunk(100)
            .ToArray();

        const string header =
            $$"""
              using System.Runtime.CompilerServices;
              using CliWrap;
              
              namespace xBuild.Shell.DotnetTools;

              public static partial class {{ShellExtensionClassName}}
              {
                 extension(Shell shell)
                 {
              """;

        const string footer =
            """
                }
            }
            """;

        for (var index = 0; index < groups.Length; index++)
        {
            var group = groups[index];
            var methods = group
                .Select(tool =>
                    $$"""
                      
                              public Command {{tool.MethodName}}(
                                  FormattableString arguments,
                                  ShellLoggingOptions? loggingOptions = null
                              ) => shell.DotnetToolCommand(
                                  FormattableStringFactory.Create($"{{tool.ToolName}} {arguments.Format}", arguments.GetArguments()),
                                  loggingOptions
                              );

                      """
                ).ToArray();

            var filePath = Path.Combine(ProjectDirectory, $"{ShellExtensionClassName}_{index}.cs");

            await using var writer = new StreamWriter(File.Create(filePath));

            await writer.WriteAsync(header);

            foreach (var method in methods)
            {
                await writer.WriteAsync(method);
            }

            await writer.WriteAsync(footer);
        }
    }
}