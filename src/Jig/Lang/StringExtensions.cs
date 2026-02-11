namespace Jig.Lang;

public static class StringExtensions
{
    extension(string? str)
    {
        public long? TryParseLong() => str != null ? long.TryParse(str, out var l) ? l : null : null;
    }
}