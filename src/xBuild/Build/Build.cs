using Microsoft.Extensions.DependencyInjection;
using xBuild.Targets;

namespace xBuild.Build;

public class ExecutableBuild(ServiceProvider serviceProvider) : IAsyncDisposable
{
    public IServiceProvider ServiceProvider => serviceProvider;
    
    public BuildRunner BuildRunner => serviceProvider.GetRequiredService<BuildRunner>();

    public async ValueTask DisposeAsync()
    {
        await serviceProvider.DisposeAsync();
    }
}

/// <summary>
///     Entry point for a build.
///     Encapsulates the service collection used to run the build, default service injection, and logic to initiate the build.
/// </summary>
public class Build : IBuild
{
    private readonly ServiceCollection _services = new();

    public Build(
        string workingDirectory = "", 
        BuildConcurrency defaultBuildConcurrency = BuildConcurrency.Sequential
    )
    {
        // Load from .env
        DotNetEnv.Env
            .TraversePath()
            .Load(AppContext.BaseDirectory);
        
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
        
        var stoppingToken = new CancellationTokenSource();
        Console.CancelKeyPress += (_, _) => stoppingToken.Cancel();
        
        var buildContext = new BuildContext(stoppingToken.Token);
        _services.AddSingleton(buildContext);
        _services.AddSingleton<IBuildContext>(s => s.GetRequiredService<BuildContext>());

        // Add Build Options
        this.AddBuildOptions(new BuildOptions(defaultBuildConcurrency));

        // Add Build Runner
        _services.AddSingleton<BuildRunner>();
        _services.AddScoped<TargetContext>();
    }

    public IServiceCollection Services => _services;
    
    public ExecutableBuild Create() => new(_services.BuildServiceProvider());
}