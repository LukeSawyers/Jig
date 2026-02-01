using System.Runtime.CompilerServices;

namespace xBuild.Lang;

public static class FormattableStringExtensions
{
    extension(FormattableString str)
    {
        public FormattableString Concat(FormattableString second)
        {
            var secondFormat = second.Format;
            for (var i = 0; i < second.ArgumentCount; i++)
            {
                secondFormat = secondFormat.Replace($"{{{i}}}", $"{{{i + str.ArgumentCount}}}");
            }

            var arguments = str.GetArguments()
                .Concat(second.GetArguments())
                .ToArray();

            return FormattableStringFactory.Create(str.Format + secondFormat, arguments);
        }

        public FormattableString ConcatString(string? second) =>
            FormattableStringFactory.Create(str.Format + second, str.GetArguments());
    }
}