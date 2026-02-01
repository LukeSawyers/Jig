namespace xBuild.Build;

public interface IBuildRunner : IAsyncDisposable
{
    IServiceProvider Services { get; }

    ValueTask<int> ExecuteAsync(string[] args);
}