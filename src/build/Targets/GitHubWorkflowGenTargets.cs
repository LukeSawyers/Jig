using GitHubActionsDotNet.Models;
using Jig.GitHubActions;
using Jig.Targets;

namespace build.Targets;

public class GitHubWorkflowGenTargets(
    Workflows workflows
) : ITargetProvider
{
    public ITarget GenerateGitHubWorkflows => field ??= new Target(description: "Genrates all github workflows")
        .DependentOn(
            () => MergeCheck,
            () => Deploy
        );
    
    public ITarget MergeCheck => field ??= new Target(description: "Generates a github workflow for use with github pull requests")
        .GeneratesGitHubActionsWorkflow(b =>
        {
            b.on = new()
            {
                workflow_dispatch = new(),
                pull_request = new()
                {
                    branches = ["**"]
                }
            };
            
            b.jobs = new()
            {
                {
                    "ubuntu-latest", new Job
                    {
                        runs_on = "ubuntu-latest",
                    }.AddStepsFromTargets(() => workflows.MergeCheck, "--plan")
                }
            };
        });
    
    public ITarget Deploy => field ??= new Target(description: "Generates a github workflow for nuget package deployment")
        .GeneratesGitHubActionsWorkflow(b =>
        {
            b.on = new()
            {
                workflow_dispatch = new(),
                push = new()
                {
                    branches = ["main"]
                }
            };
            
            b.jobs = new()
            {
                {
                    "ubuntu-latest", new Job
                    {
                        runs_on = "ubuntu-latest",
                    }.AddStepsFromTargets(() => workflows.Deploy, "--plan")
                }
            };
        });
}