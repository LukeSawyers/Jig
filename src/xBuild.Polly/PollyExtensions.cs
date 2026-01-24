using Polly;
using xBuild.Build;
using xBuild.Targets;

namespace xBuild.Polly;

public static class PollyExtensions
{
    extension<T>(T target) where T : ITarget
    {
        /// <summary>
        ///     Applies the configured resilience policy to the most recently configured execution.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        ///     If the target has no execution configured
        /// </exception>
        public T WithResilience(Func<ResiliencePipelineBuilder, ResiliencePipelineBuilder> builder)
        {
            if (!target.Executions.Any())
            {
                throw new InvalidOperationException("No executions available on target");
            }

            var lastIndex = target.Executions.Count - 1;
            var lastExecution = target.Executions[lastIndex];

            var pipeline = builder(new ResiliencePipelineBuilder()).Build();

            ValueTask WrappedExecution(IBuildContext context, IServiceProvider provider, CancellationToken cancellation)
            {
                return pipeline.ExecuteAsync(ct =>
                {
                    var linkedCancellation = CancellationTokenSource.CreateLinkedTokenSource(cancellation, ct);
                    return lastExecution.ExecuteAsync(context, provider, linkedCancellation.Token);
                });
            }

            target.Executions[lastIndex] = lastExecution with
            {
                Execution = WrappedExecution
            };

            return target;
        }
    }
}