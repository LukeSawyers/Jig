using DotNetEnv;
using Microsoft.Extensions.DependencyInjection;

namespace Jig.Build;

/// <summary>
///     Entry point for a build.
///     Encapsulates the service collection used to run the build, default service injection, and logic to initiate the build.
/// </summary>
public class Build : IBuild
{
    /// <inheritdoc />
    public IServiceCollection Services => _services;

    private readonly ServiceCollection _services = new();

    public Build(
        string workingDirectory = "",
        BuildConcurrency defaultBuildConcurrency = BuildConcurrency.Sequential
    )
    {
        // Load from .env
        Env.TraversePath().Load(AppContext.BaseDirectory);

        // Add Build Context
        var rootDirectory = new DirectoryInfo(AppContext.BaseDirectory);
        while (true)
        {
            if (rootDirectory is null)
            {
                throw new ArgumentNullException(nameof(rootDirectory));
            }

            if (rootDirectory.EnumerateDirectories().Any(d => d.Name == ".git"))
            {
                break;
            }

            rootDirectory = rootDirectory.Parent;
        }

        rootDirectory = new DirectoryInfo(Path.Combine(rootDirectory.FullName, workingDirectory));

        Directory.SetCurrentDirectory(rootDirectory.FullName);

        var buildContext = new BuildContext();
        Console.CancelKeyPress += (_, _) => buildContext.Cancel();

        _services.AddSingleton(buildContext);
        _services.AddSingleton<IBuildContext>(s => s.GetRequiredService<BuildContext>());

        // Add Build Options
        this.AddBuildOptions(new BuildOptions(defaultBuildConcurrency));

        // Add Build Runner
        _services.AddSingleton<BuildRunner>();
    }

    /// <inheritdoc />
    public IBuildRunner Create() => _services.BuildServiceProvider().GetRequiredService<BuildRunner>();
}