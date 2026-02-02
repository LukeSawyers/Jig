using System.CommandLine;
using Jig.Options;

namespace Jig.UserInput;

/// <summary>
///     Options required for user input
/// </summary>
public class UserInputOptions : IOptionsProvider
{
    public BuildOption<bool> Interactive { get; } = new(
        false,
        new Option<bool>("--interactive")
        {
            Description = "Allows user interaction during the build",
        }
    );
}