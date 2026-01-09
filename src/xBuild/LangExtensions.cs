using System.Reflection;

namespace xBuild;

public static class LangExtensions
{
    extension(object obj)
    {
        public IEnumerable<T?> ReflectProperties<T>(
            BindingFlags flags
        ) where T : class => obj.GetType()
            .GetProperties(flags)
            .Where(f => f.PropertyType.IsAssignableTo(typeof(T)))
            .Select(f => f.GetValue(obj) as T);
    }

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

    extension<T>(T arg)
    {
        public TOut Let<TOut>(Func<T, TOut> func) => func(arg);

        public T Apply(Action<T> func)
        {
            func(arg);
            return arg;
        }
        
        public T ApplyIf(bool condition, Action<T> func)
        {
            if (condition)
            {
                func(arg);
            }
     
            return arg;
        }
    }

    extension<T>(Task<T> task)
    {
        public async Task<TOut> LetAsync<TOut>(Func<T, TOut> func) => func(await task);
    }

    extension<T>(ValueTask<T> task)
    {
        public async ValueTask<TOut> LetAsync<TOut>(Func<T, TOut> func) => func(await task);
    }
}