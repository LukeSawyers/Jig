using System.Reflection;

namespace Jig.Lang;

public static class ObjectExtensions
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
    
    extension<T>(T arg)
    {
        public TOut Let<TOut>(Func<T, TOut> func) => func(arg);

        public T Apply(Action<T> func)
        {
            func(arg);
            return arg;
        }

        public T If(Func<bool> condition, Action<T> func) => arg.If(condition(), func);

        public T If(bool condition, Action<T> func)
        {
            if (condition)
            {
                func(arg);
            }

            return arg;
        }
        
        public T LetIf(bool condition, Func<T, T> func) => condition ? func(arg) : arg;
    }
}