namespace Jig.Lang;

public static class EnumerableExtensions
{
    extension<T>(IEnumerable<T?> enumerable) where T : class
    {
        public IEnumerable<T> WhereNotNull() => enumerable
            .Where(item => item != null)
            .Select(i => i!);
    }

    extension(IEnumerable<string> enumerable)
    {
        public string StringJoin(string separator = "") => string.Join(separator, enumerable);
    }

    extension<T>(IEnumerable<T> enumerable)
    {
        public IEnumerable<TOut> SelectFrom<TOut>(
            IReadOnlyDictionary<T, TOut> dictionary
        ) where TOut : class => enumerable
            .Select(dictionary.GetValueOrDefault)
            .WhereNotNull();

        public string StringJoin(Func<T, string> mapper, string separator = "") =>
            enumerable.Select(mapper).StringJoin(separator);
    }
}

