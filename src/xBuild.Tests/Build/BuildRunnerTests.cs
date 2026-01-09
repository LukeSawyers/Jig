using System.CommandLine;
using System.Runtime.CompilerServices;
using AwesomeAssertions;
using Microsoft.Extensions.DependencyInjection;
using xBuild.Build;
using xBuild.Logging;
using xBuild.Options;
using xBuild.Targets;
using Xunit.Abstractions;

namespace xBuild.Tests.Build;

public class BuildRunnerTests(ITestOutputHelper outputHelper)
{
    private BuildContext BuildContext => Build.ServiceProvider.GetRequiredService<BuildContext>();

    private TestTargets Targets => Build.ServiceProvider.GetRequiredService<TestTargets>();

    private ExecutableBuild Build => field ??= new xBuild.Build.Build()
        .Apply(b => { b.Services.AddSingleton(outputHelper); })
        .AddLogging<XUnitBuildLogger>()
        .AddTargets<TestTargets>()
        .Create();

    private void AssertTargetExecuted(TestTarget target, TargetExecutionResultType resultType)
    {
        target.Executed.Should().BeTrue();
        BuildContext.Targets.Should().ContainKey(target);
        var result = BuildContext.Targets[target];
        result.Should().NotBeNull();
        result.ResultType.Should().Be(resultType);
    }

    private void AssertTargetNotExecuted(TestTarget target)
    {
        target.Executed.Should().BeFalse();
        // Assert.Equivalent(TargetExecutionStatus.Inconclusive, _buildContext.Targets[target]);
    }

    private void AssertTargetNotPlanned(TestTarget target)
    {
        target.Executed.Should().BeFalse();
        BuildContext.Targets.Should().NotContainKey(target);
    }

    [Fact]
    public async Task RunsAllSpecifiedTargets()
    {
        // Act
        await Build.BuildRunner.ExecuteAsync([nameof(TestTargets.BasicTask1), nameof(TestTargets.BasicTask2)]);

        // Assert
        AssertTargetExecuted(Targets.BasicTask1, TargetExecutionResultType.Succeeded);
        AssertTargetExecuted(Targets.BasicTask2, TargetExecutionResultType.Succeeded);
    }

    [Fact]
    public async Task RunsOnlySpecifiedTargets()
    {
        // Act
        await Build.BuildRunner.ExecuteAsync([nameof(TestTargets.BasicTask1)]);

        // Assert
        AssertTargetExecuted(Targets.BasicTask1, TargetExecutionResultType.Succeeded);
        AssertTargetNotPlanned(Targets.BasicTask2);
    }

    [Fact]
    public async Task SetsOptionValues()
    {
        // Arrange
        var stringArgValue = "someString";

        // Act
        await Build.BuildRunner.ExecuteAsync([nameof(TestTargets.BasicTask1), "--arg1", "--arg2", stringArgValue]);

        // Assert
        Targets.Arg1.Value.Should().BeTrue();
        Targets.Arg2.Value.Should().BeEquivalentTo(stringArgValue);
    }

    [Fact]
    public async Task RunsDependentTargets()
    {
        // Act
        await Build.BuildRunner.ExecuteAsync([nameof(TestTargets.DependentTaskC)]);

        // Assert
        // Basic tasks should not get run at all
        AssertTargetNotPlanned(Targets.BasicTask1);
        AssertTargetNotPlanned(Targets.BasicTask2);

        // B is "dependent on" A
        AssertTargetExecuted(Targets.DependentTaskA, TargetExecutionResultType.Succeeded);

        // B is "dependent for" C
        AssertTargetExecuted(Targets.DependentTaskB, TargetExecutionResultType.Succeeded);

        // C is executed directly
        AssertTargetExecuted(Targets.DependentTaskC, TargetExecutionResultType.Succeeded);

        // D is also dependent on B, but wasn't invoked
        AssertTargetNotPlanned(Targets.DependentTaskD);
    }

    [Fact]
    public async Task RunsDependentTargets_ExceptExcluded()
    {
        // Act
        await Build.BuildRunner.ExecuteAsync([
            nameof(TestTargets.DependentTaskC), "--exclude", nameof(TestTargets.DependentTaskA)
        ]);

        // Assert
        // Basic tasks should not get run at all

        // B is "dependent on" A, but was skipped
        AssertTargetNotPlanned(Targets.DependentTaskA);

        // B is "dependent for" C
        AssertTargetExecuted(Targets.DependentTaskB, TargetExecutionResultType.Succeeded);

        // C is executed directly
        AssertTargetExecuted(Targets.DependentTaskC, TargetExecutionResultType.Succeeded);
    }

    [Fact]
    public async Task RunsTriggeredTargets()
    {
        // Act
        await Build.BuildRunner.ExecuteAsync([nameof(TestTargets.TriggeredTaskA)]);

        // Assert
        // A is executed directly 
        AssertTargetExecuted(Targets.TriggeredTaskA, TargetExecutionResultType.Succeeded);
        // B is "triggered after" A
        AssertTargetExecuted(Targets.TriggeredTaskB, TargetExecutionResultType.Succeeded);
        // B "triggers before" C
        AssertTargetExecuted(Targets.TriggeredTaskC, TargetExecutionResultType.Succeeded);
    }

    [Fact]
    public async Task RunsTriggeredTargets_ExceptExcluded()
    {
        // Act
        await Build.BuildRunner.ExecuteAsync([
            nameof(TestTargets.TriggeredTaskA), "--exclude", nameof(TestTargets.TriggeredTaskC)
        ]);

        // Assert
        // A is executed directly 
        AssertTargetExecuted(Targets.TriggeredTaskA, TargetExecutionResultType.Succeeded);
        // B is "triggered after" A
        AssertTargetExecuted(Targets.TriggeredTaskB, TargetExecutionResultType.Succeeded);
        // B "triggers before" C, but was skipped
        AssertTargetNotPlanned(Targets.TriggeredTaskC);
    }

    [Fact]
    public async Task ProceedAfterFailure_RunsSubsequentTasks()
    {
        // Act
        await Build.BuildRunner.ExecuteAsync([nameof(TestTargets.ProceedAfterFailure)]);

        // Assert
        // Proceed after failure task was run, but failed
        AssertTargetExecuted(Targets.ProceedAfterFailure, TargetExecutionResultType.Failed);
        // Basic task 1 was run successfully
        AssertTargetExecuted(Targets.BasicTask1, TargetExecutionResultType.Succeeded);
    }

    [Fact]
    public async Task ExecuteAfterFailure_RunsSubsequentTasks()
    {
        // Act
        await Build.BuildRunner.ExecuteAsync([nameof(TestTargets.ExecutedAfterFailure), nameof(TestTargets.BasicTask1)]);

        // Assert
        // The failure task was run and failed
        AssertTargetExecuted(Targets.FailingTask, TargetExecutionResultType.Failed);
        // Executed after failure task was run despite previous failure and succeeded
        AssertTargetExecuted(Targets.ExecutedAfterFailure, TargetExecutionResultType.Succeeded);
        // Basic task 1 was not run
        AssertTargetNotExecuted(Targets.BasicTask1);
    }

    public class TestTarget : Target
    {
        public TestTarget([CallerMemberName] string name = "") : base(name)
        {
            this.Executes(() => Executed = true);
        }

        public bool Executed { get; set; }
    }

    private class TestTargets : ITargetProvider
    {
        // Options
        public BuildOption<bool> Arg1 { get; } = new(
            false,
            new Option<bool>("--arg1")
        );
        public BuildOption<string> Arg2 { get; } = new(
            string.Empty,
            new Option<string>("--arg2")
        );

        // Basic Tasks
        public TestTarget BasicTask1 => field ??= new TestTarget();

        public TestTarget BasicTask2 => field ??= new TestTarget();

        // Dependent Tasks, A -> B -> C, D
        public TestTarget DependentTaskA => field ??= new TestTarget();

        public TestTarget DependentTaskB => field ??= new TestTarget()
            .DependsOn(() => DependentTaskA)
            .DependentFor(
                () => DependentTaskC,
                () => DependentTaskD
            );

        public TestTarget DependentTaskC => field ??= new TestTarget();

        public TestTarget DependentTaskD => field ??= new TestTarget();

        // Triggered Tasks, A -> B -> C
        public TestTarget TriggeredTaskA => field ??= new TestTarget();

        public TestTarget TriggeredTaskB => field ??= new TestTarget()
            .TriggeredAfter(() => TriggeredTaskA)
            .TriggersBefore(() => TriggeredTaskC);

        public TestTarget TriggeredTaskC => field ??= new TestTarget();

        // Failure mode tasks
        public TestTarget FailingTask => field ??= new TestTarget()
            .Executes(() =>
            {
                FailingTask.Executed = true;
                throw new Exception();
            });

        public TestTarget ProceedAfterFailure => field ??= new TestTarget()
            .ProceedAfterFailure()
            .TriggersBefore(() => BasicTask1)
            .Executes(() =>
            {
                ProceedAfterFailure.Executed = true;
                throw new Exception();
            });

        public TestTarget ExecutedAfterFailure => field ??= new TestTarget()
            .DependsOn(() => FailingTask)
            .ExecuteAfterFailure();
    }
}