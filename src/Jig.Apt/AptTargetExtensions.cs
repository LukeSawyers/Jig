using System.ComponentModel.DataAnnotations;
using CliWrap;
using Jig.Targets;
using Jig.UserInput;
using Microsoft.Extensions.Logging;

namespace Jig.Apt;

public static class AptTargetExtensions
{
    extension<T>(T target) where T : ITarget
    {
        /// <summary>
        /// Adds an execution to this target that ensures that the specified apt package is installed.
        /// If user input is enabled, it will present options for the user to install the package.
        /// </summary>
        /// <param name="package">The apt package</param>
        /// <param name="install">Attempt to install if not present without prompting</param>
        /// <returns></returns>
        public T RequireAptPackage(string package, bool install = false)
        {
            return target.Executes(async (
                    ILogger logger,
                    Shell.Shell shell,
                    IUserInput? userInput = null
                ) =>
                {
                    var packageStatusResult = await shell
                        .Command($"dpkg -s {package}")
                        .WithValidation(CommandResultValidation.None)
                        .ExecuteAsync();

                    if (packageStatusResult.IsSuccess)
                    {
                        logger.LogInformation("Validated apt package {Package}", package);
                        return;
                    }

                    if (!install)
                    {
                        if (userInput?.Enabled == true)
                        {
                            install = await userInput.PromptBoolAsync($"Install {package}?");
                        }
                    }

                    if (!install)
                    {
                        throw new ValidationException(
                            $"Apt package {package} was required by {target.Name} but was not installed"
                        );
                    }

                    await shell
                        .Command($"sudo apt-get install {package}")
                        .WithStandardInputPipe(userInput?.CreateInputPipeSource() ?? PipeSource.Null)
                        .ExecuteAsync();
                },
                $"Require that apt package {package} is installed, and prompt user to install if not"
            );
        }
    }
}