using System.ComponentModel.DataAnnotations;
using CliWrap;
using xBuild.UserInput;
using xBuild.Logging;
using xBuild.Shell;
using xBuild.Targets;

namespace xBuild.Apt;

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
            target.Executes(async (
                ITargetLogger logger,
                IUserInput userInput,
                TargetShell shell
            ) =>
            {
                foreach (var package in packages)
                {
                    var packageStatusResult = await shell
                        .Command($"dpkg -s {package}")
                        .WithValidation(CommandResultValidation.None)
                        .ExecuteAsync();

                    if (packageStatusResult.IsSuccess)
                    {
                        logger.LogInformation($"Validated apt package {package}");
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
                }
            });
            
            return target;
        }
    }
}