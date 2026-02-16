using GitHubActionsDotNet.Helpers;
using GitHubActionsDotNet.Models;
using Jig.GitHubActions;
using Jig.Targets;

namespace build.Targets;

public class GitHubWorkflowGenTargets(
    DotnetTargets dotnet,
    Workflows workflows
) : ITargetProvider
{
    public ITarget GenerateGitHubWorkflows => field ??= new Target(description: "Generates all github workflows")
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
                        steps = 
                        [
                            CommonStepHelper.AddCheckoutStep(fetchDepth: "0"), 
                            TargetStepHelper.ScriptStepFromTargets(workflows.Validate, "--plan")
                        ]
                    }
                },
                {
                    "windows-latest", new Job()
                    {
                        runs_on = "windows-latest",
                        steps = 
                        [
                            CommonStepHelper.AddCheckoutStep(fetchDepth: "0"), 
                            TargetStepHelper.ScriptStepFromTargets(workflows.ValidateCode, "--plan")
                        ]
                    }
                },
                {
                    "macos-latest", new Job()
                    {
                        runs_on = "macos-latest",
                        steps = 
                        [
                            CommonStepHelper.AddCheckoutStep(fetchDepth: "0"), 
                            TargetStepHelper.ScriptStepFromTargets(workflows.ValidateCode, "--plan")
                        ]
                    }
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
                        steps = 
                        [
                            CommonStepHelper.AddCheckoutStep(fetchDepth: "0"), 
                            TargetStepHelper.ScriptStepFromTargets(
                                workflows.Deploy, 
                                "--plan",
                                TargetStepHelper.ArgFromSecrets(dotnet.NugetApiKey)
                            )
                        ]
                    }
                }
            };
        });
}