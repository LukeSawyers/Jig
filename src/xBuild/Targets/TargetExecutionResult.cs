namespace xBuild.Targets;

public record TargetExecutionResult(
    TargetExecutionResultType ResultType,
    TimeSpan ExecutionTime
);