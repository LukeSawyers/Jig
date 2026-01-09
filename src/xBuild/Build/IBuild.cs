using Microsoft.Extensions.DependencyInjection;

namespace xBuild.Build;

public interface IBuild
{
    IServiceCollection Services { get; }

    ExecutableBuild Create();

    async Task ExecuteAsync(string[] args)
    {
        await using var executable = Create();
        await executable.BuildRunner.ExecuteAsync(args);
    }
}