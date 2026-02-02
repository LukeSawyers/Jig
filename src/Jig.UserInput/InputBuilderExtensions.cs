using Microsoft.Extensions.DependencyInjection;
using Jig.Build;

namespace Jig.UserInput;

public static class InputBuilderExtensions
{
    extension<T>(T build) where T : IBuild
    {
        /// <summary>
        /// Adds required dependencies to allow for user input
        /// </summary>
        /// <returns></returns>
        public T AddUserInput()
        {
            build.AddBuildOptions<UserInputOptions>();
            build.Services.AddSingleton<IUserInput, ConsoleInput>();
            return build;
        }
    }
}