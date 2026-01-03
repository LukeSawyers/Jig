namespace TacticalNuke;

public static class LangExtensions
{
    extension<T>(IEnumerable<T?> enumerable) where T : class
    {
        public IEnumerable<T> WhereNotNull()
        {
            return enumerable
                .Where(item => item != null)
                .Select(i => i!);
        }
    }

    extension(IEnumerable<string> enumerable)
    {
        public string StringJoin(string separator = "")
        {
            return string.Join(separator, enumerable);
        }
    }

    extension<T>(IEnumerable<T> enumerable)
    {
        public string StringJoin(Func<T, string> mapper, string separator = "")
        {
            return enumerable.Select(mapper).StringJoin(separator);
        }
    }

    extension<T>(T arg)
    {
        public TOut Let<TOut>(Func<T, TOut> func)
        {
            return func(arg);
        }
    }

    extension<T>(Task<T> task)
    {
        public async Task<TOut> LetAsync<TOut>(Func<T, TOut> func)
        {
            return func(await task);
        }
    }

    extension<T>(ValueTask<T> task)
    {
        public async ValueTask<TOut> LetAsync<TOut>(Func<T, TOut> func)
        {
            return func(await task);
        }
    }
}