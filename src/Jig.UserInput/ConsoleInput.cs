using System.Text;
using CliWrap;

namespace Jig.UserInput;

/// <summary>
///     Simple default console implementation of <see cref="IUserInput"/>
/// </summary>
/// <param name="buildOptions"></param>
public class ConsoleInput(UserInputOptions buildOptions) : IUserInput
{
    /// <inheritdoc/>
    public bool Enabled => buildOptions.Interactive;

    /// <inheritdoc/>
    public async ValueTask<string> PromptAsync(string display)
    {
        if (!buildOptions.Interactive)
        {
            throw new InvalidOperationException("");
        }

        Console.Write($"{display}: ");
        return Console.ReadLine() ?? string.Empty;
    }

    /// <inheritdoc/>
    public async ValueTask<bool> PromptBoolAsync(string display, bool? defaultValue = null)
    {
        var yes = defaultValue == true ? "Y" : "y";
        var no = defaultValue == false ? "N" : "n";
        var displayWithOptions = $"{display} [{yes}/{no}]";
        var result = await PromptAsync(displayWithOptions);

        var emptyString = string.IsNullOrEmpty(result) || string.IsNullOrWhiteSpace(result);
        
        if (emptyString && defaultValue is { } def)
        {
            return def;
        }

        var isYes = result.ToLowerInvariant().Trim() == "y";
        var isNo = result.ToLowerInvariant().Trim() == "n";

        if (isYes)
        {
            return true;
        }

        if (isNo)
        {
            return false;
        }

        Console.WriteLine($"'{result}' was not a recognised input");
        return await PromptBoolAsync(display, defaultValue);
    }

    /// <inheritdoc/>
    public PipeSource CreateInputPipeSource() => PipeSource.Create(async (stream, ct) =>
    {
        if (!buildOptions.Interactive)
        {
            throw new InvalidOperationException("");
        }

        await using var writer = new StreamWriter(stream, Encoding.UTF8, leaveOpen: true)
        {
            AutoFlush = true
        };

        while (ct.IsCancellationRequested)
        {
            var key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }

            if (key.Key == ConsoleKey.Enter)
            {
                await writer.WriteAsync("\n");
            }
            else if (!char.IsControl(key.KeyChar))
            {
                await writer.WriteAsync(key.KeyChar);
            }
        }
    });
}