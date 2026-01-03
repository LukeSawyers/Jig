using System.Threading.Channels;
using CliWrap;

namespace TacticalNuke.Commands;

public static class CommandExtensions
{
    extension(Command command)
    {
        /// <summary>
        ///     Execute the command returning each standard output line as an async enumerable.
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        public async IAsyncEnumerable<string> ExecuteAndCaptureOutputAsync(CancellationToken stoppingToken)
        {
            var output = Channel.CreateUnbounded<string>();
            var commandExecution = command
                .WithStandardOutputPipe(PipeTarget.ToDelegate(async line =>
                    await output.Writer.WriteAsync(line, stoppingToken)))
                .ExecuteAsync(stoppingToken);

            while (true)
            {
                // Wait for either an output line or for the process to complete
                var readTask = output.Reader.ReadAsync(stoppingToken).AsTask();
                await Task.WhenAny(commandExecution.Task, readTask);
                // If the read task was the one that completed, yield return then retry
                if (readTask.IsCompletedSuccessfully)
                    yield return readTask.Result;
                else
                    break;
            }

            await commandExecution.Task;
        }
    }
}