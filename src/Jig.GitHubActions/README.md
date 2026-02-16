# Jig.GitHubActions

## Overview

Provides extensions and helpers for:

- Adding target executions for generating github actions workflow files
- Interacting with github actions 

## Usage

Call `.GeneratesGitHubActionsWorkflow()` on a target to make the target generate a workflow. 
The method accepts a builder lambda which will allow you to construct the workflow. 

To create a job that runs targets, call helper methods to generate script steps from `ITarget`s and `IBuildOption`s: 
```csharp
.GeneratesGitHubActionsWorkflow(b =>
{    
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
                        // Invokes this target
                        workflows.Deploy, 
                        "--plan",
                        // With this cli parameter using a secret
                        TargetStepHelper.ArgFromSecrets(dotnet.NugetApiKey)
                    )
                ]
            }
        }
    };
});
```

The workflow will be named after the target. 
The target's name will be changed to GenerateWorkflow_{TargetName}

To access GitHub Environment variables, `GitHubActionsEnvironment` static class is available with 
environment variable bindings.

## Acknowledgements

Made trivial by [GitHubActionsDotNet](https://github.com/samsmithnz/GitHubActionsDotNet)