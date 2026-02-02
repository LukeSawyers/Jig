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
        /// Adds an execution to this target that ensures that all the specified apt packages are installed.
        /// If user input is enabled, it will present options for the user to install the package.
        /// </summary>
        /// <param name="packages"></param>
        /// <returns></returns>
        public T RequireAptPackage(params string[] packages)
        {
            foreach (var package in packages)
            {
                target.RequireAptPackageInternal(package);
            }

            return target;
        }

        private void RequireAptPackageInternal(string package)
        {
            target.Executes(async (
                    ILogger logger,
                    IUserInput userInput,
                    Shell.Shell shell
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

                    var notInstalledException = new ValidationException(
                        $"Apt package {package} was required by {target.Name} but was not installed"
                    );

                    if (!userInput.Enabled)
                    {
                        throw notInstalledException;
                    }

                    var install = await userInput.PromptBoolAsync($"Install {package}?");

                    if (!install)
                    {
                        throw notInstalledException;
                    }

                    await shell
                        .Command($"sudo apt-get install {package}")
                        .WithStandardInputPipe(userInput.CreateInputPipeSource())
                        .ExecuteAsync();
                },
                $"Require that apt package {package} is installed, and prompt user to install if not"
            );
        }
    }
}