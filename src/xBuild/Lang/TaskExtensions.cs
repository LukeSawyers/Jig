namespace xBuild.Lang;

public static class TaskExtensions
{
    extension<T>(Task<T> task)
    {
        public async Task<TOut> LetAsync<TOut>(Func<T, TOut> func) => func(await task);
    }

    extension<T>(ValueTask<T> task)
    {
        public async ValueTask<TOut> LetAsync<TOut>(Func<T, TOut> func) => func(await task);
    }
}