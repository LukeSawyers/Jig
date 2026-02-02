namespace Jig.Targets;

public record TargetExecutionResult(
    TargetExecutionResultType ResultType,
    TimeSpan ExecutionTime
);