using System.Drawing;
using Serilog.Core;
using Serilog.Events;

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
                var colored = $"{AnsiConsoleUtils.AnsiTrueColor(ColorFromValue(value))}{value}{AnsiConsoleUtils.Reset}";
                logEvent.AddOrUpdateProperty(propertyFactory.CreateProperty(prop.Key, colored));
            }
        }
    }

    private static Color ColorFromValue(object value)
    {
        var s = value.ToString() ?? "";
        using var sha = System.Security.Cryptography.SHA1.Create();
        var hash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(s));

        var brightnessMultiplier = (float)byte.MaxValue / hash.Take(3).Max();

        var r = (int)(hash[0] * brightnessMultiplier);
        var g = (int)(hash[1] * brightnessMultiplier);
        var b = (int)(hash[2] * brightnessMultiplier);

        return Color.FromArgb(r, g, b);
    }
}