using CliWrap;

namespace Jig.UserInput;

/// <summary>
///     Service that provides methods to prompt and accespt user input 
/// </summary>
public interface IUserInput
{
    /// <summary>
    ///     true: User interaction is enabled
    ///     false: User interaction is disabled. Attempting to call prompt methods will throw.
    /// </summary>
    bool Enabled { get; }
    
    /// <summary>
    ///     Requests input from the user and returns the string they enter
    /// </summary>
    /// <param name="display"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">If interaction is not enabled</exception>
    ValueTask<string> PromptAsync(string display);
    
    /// <summary>
    ///     Presents a yes/no option to the user and requires the user to select one, rejecting any invalid inputs.
    ///     Returns the <paramref name="defaultValue"/> if specified.
    /// </summary>
    /// <param name="display"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">If interaction is not enabled</exception>
    ValueTask<bool> PromptBoolAsync(string display, bool? defaultValue = null);

    /// <summary>
    ///     Creates a <see cref="PipeSource"/> for the user
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">If interaction is not enabled</exception>
    PipeSource CreateInputPipeSource();
}