namespace Jig.Build;

public interface IBuildRunner : IAsyncDisposable
{
    IServiceProvider Services { get; }

    ValueTask<int> ExecuteAsync(params string[] args);
}