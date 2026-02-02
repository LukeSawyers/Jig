using Microsoft.Extensions.DependencyInjection;

namespace Jig.Build;

public interface IBuild
{
    IServiceCollection Services { get; }

    IBuildRunner Create();

    async ValueTask<int> ExecuteAsync(string[] args)
    {
        await using var executable = Create();
        return await executable.ExecuteAsync(args);
    }
}