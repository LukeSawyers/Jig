using System.Drawing;

namespace Jig.Serilog;

public static class AnsiConsoleUtils
{
    public const string Reset = "\x1b[0m";

    public static string AnsiTrueColor(
        Color foreground,
        Color? background = null,
        bool bold = false
    )
    {
        var boldCode = bold ? "1;" : string.Empty;
        var code = $"\x1b[{boldCode}38;2;{foreground.R};{foreground.G};{foreground.B}";

        if (background is { } bg)
        {
            code += $";48;2;{bg.R};{bg.G};{bg.B}";
        }

        code += "m";
        return code;
    }
}