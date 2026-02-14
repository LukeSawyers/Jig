using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using ColorHelper;
using Serilog.Core;
using Serilog.Events;
using ColorConverter = ColorHelper.ColorConverter;

namespace Jig.Serilog;

public class AnsiParameterColorer(string[] parameterNames) : ILogEventEnricher
{
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        // Go through all properties
        foreach (var prop in logEvent.Properties)
        {
            if (parameterNames.Contains(prop.Key) && prop.Value is ScalarValue { Value: { } value })
            {
                var background = ColorFromValue(value);
                var colored = $"{AnsiConsoleUtils.AnsiTrueColor(background, bold: true)}{value}{AnsiConsoleUtils.Reset}";
                logEvent.AddOrUpdateProperty(propertyFactory.CreateProperty(prop.Key, colored));
            }
        }
    }

    private static Color ColorFromValue(object value)
    {
        var s = value.ToString() ?? "";
        using var sha = SHA1.Create();
        var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(s));
        var hue = BitConverter.ToInt32(hash) % 360;
        hue = hue > 0 ? hue : hue * -1;
        var color = ColorConverter.HsvToRgb(new HSV(hue, 100, 70));
        return Color.FromArgb(color.R, color.G, color.B);
    }
}