using xBuild.Targets;

namespace xBuild.Incremental;

public static class InrementalTargetExtensions
{
    extension(ITarget target)
    {
        /// <summary>
        ///     Adds an execution running the specified dotnet tool <paramref name="command" /> in exec mode
        /// </summary>
        /// <returns></returns>
        public ITarget WithIncrementation()
        {
            // Compare hashes for changes
            
            // If there is a change, execute the target as normal
            
            // If there is no change, reflect the execution return type and try to deserialize the stored result
            
            // If loading was successful, return that result
            
            // If loading failed, execute the target
            
            // Get the output type of the previous execution
            
            // 
            
            return target.Executes(async (TargetShell shell, CancellationToken stoppingToken) => await shell
                .DotnetToolCommand(command, validation, logging)
                .ExecuteAndCaptureJsonOutputAsync<TOutput>(stoppingToken));
        }
    }
}