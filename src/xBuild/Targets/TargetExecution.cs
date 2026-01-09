using Microsoft.Extensions.DependencyInjection;

namespace xBuild.Targets;

public static class TargetExecution
{
    public static async ValueTask ExecuteAsync(
        IServiceProvider services,
        Delegate execution,
        CancellationToken cancellation
    )
    {
        var args = execution.Method.GetParameters()
            .Select(p => p.ParameterType == typeof(CancellationToken)
                ? cancellation
                : services.GetRequiredService(p.ParameterType))
            .ToArray();

        var result = execution.DynamicInvoke(args);
        switch (result)
        {
            case Task task:
            {
                await task;
                break;
            }
            case ValueTask valueTask:
            {
                await valueTask;
                break;
            }
        }
    }
}