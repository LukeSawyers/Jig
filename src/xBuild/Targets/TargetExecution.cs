using System.Reflection;
using Microsoft.Extensions.Logging;
using xBuild.Build;

namespace xBuild.Targets;

public record TargetExecution(
    Delegate Execution,
    FormattableString Description
)
{
    public async ValueTask ExecuteAsync(
        ILogger logger,
        IBuildContext buildContext,
        IServiceProvider services,
        CancellationToken stoppingToken
    )
    {
        // var args = Execution.Method
        //     .GetParameters()
        //     .Select(ResolveParameterDependency)
        //     .ToArray();

        // var result = Execution.DynamicInvoke(args);
        
        var method = Execution.GetType().GetMethod("Invoke")!;
        var args = method
            .GetParameters()
            .Select(ResolveParameterDependency)
            .ToArray();
        
        var result = method.Invoke(Execution, args);
        
        switch (result)
        {
            // Await tasks and if they have results, add them as outputs
            case Task task:
            {
                await HandleTask(task);
                break;
            }
            case ValueTask valueTask:
            {
                await HandleTask(valueTask.AsTask());
                break;
            }
            // TODO: Handle tuples, these should get broken out
            // All other non null return values get added as outputs 
            case { } value:
            {
                buildContext.TargetOutputs[value.GetType()] = value;
                break;
            }
        }

        return;

        object? ResolveParameterDependency(ParameterInfo p)
        {
            if (p.ParameterType == typeof(CancellationToken))
            {
                return stoppingToken;
            }

            if (p.ParameterType == typeof(ILogger))
            {
                return logger;
            }

            var result = services.GetService(p.ParameterType);
            result ??= buildContext.TargetOutputs.TryGetValue(p.ParameterType, out var val) ? val : null;

            if (result is null && !p.IsOptional)
            {
                throw new InvalidOperationException($"Unable to resolve target dependency {p.ParameterType.Name}");
            }

            return result;
        }
        
        async Task HandleTask(Task task)
        {
            await task;
            var taskType = task.GetType();
            if (!taskType.IsGenericType)
            {
                return;
            }

            var value = taskType
                .GetProperty(nameof(Task<>.Result))!
                .GetValue(task);

            if (value is null)
            {
                return;
            }

            if (value.GetType().FullName == "System.Threading.Tasks.VoidTaskResult")
            {
                return;
            }

            buildContext.TargetOutputs[value.GetType()] = value;
        }
    }
}