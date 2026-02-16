using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;
using AwesomeAssertions;
using GitHubActionsDotNet.Models;
using Jig.Build;
using Jig.Lang;
using Jig.Targets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;
using Target = Jig.Targets.Target;

namespace Jig.GitHubActions.Tests;

[UsesVerify]
public class GenerateGitHubActionsWorkflowTests(ITestOutputHelper outputHelper)
{
    class TestTargets : ITargetProvider
    {
        public ITarget Target => field ??= new Target(description: "Hello World");
    
        public ITarget Workflow => field ??= new Target(description: "Generates a github workflow for use with github pull requests")
            .GeneratesGitHubActionsWorkflow(b =>
            {
                b.on = new()
                {
                    workflow_dispatch = new()
                };
            
                b.jobs = new()
                {
                    {
                        "ubuntu-latest", new Job
                        {
                            runs_on = "ubuntu-latest",
                            steps = [TargetStepHelper.ScriptStepFromTargets(Target)]
                        }
                    }
                };
            });
    }

    private readonly MockFileSystem _fileSystem = new();
    
    private IBuildRunner CreateBuild() => new Build.Build("src")
        .AddTargets<TestTargets>()
        .Apply(b =>
        {
            b.Services.AddSingleton<IFileSystem>(_fileSystem);
            b.Services.AddLogging(b => b.AddXunit(outputHelper));
        })
        .Create();
    
    [Fact]
    public async Task VerifyGeneratedWorkflow()
    {
        // Arrange
        var buildRunner = CreateBuild();
        var expectedFilePath = Path.Combine(IBuildContext.RepositoryRootDirectory, ".github", "workflows", "workflow.yml");

        // Act
        await buildRunner.ExecuteAsync("GenerateWorkflow_Workflow");

        // Assert
        var file = _fileSystem.AllFiles.Should().ContainSingle()
            .Which.Should().BeEquivalentTo(expectedFilePath)
            .And.Subject;
        
        var fileContent = await _fileSystem.File.ReadAllTextAsync(file);
        await Verify(fileContent);
    }
}