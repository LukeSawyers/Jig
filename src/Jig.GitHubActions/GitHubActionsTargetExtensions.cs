using System.IO.Abstractions;
using GitHubActionsDotNet.Helpers;
using GitHubActionsDotNet.Models;
using GitHubActionsDotNet.Serialization;
using Humanizer;
using Jig.Build;
using Jig.Lang;
using Jig.Targets;

namespace Jig.GitHubActions;

public static class GitHubActionsTargetExtensions
{
    extension<TTarget>(TTarget target) where TTarget : ITarget
    {
        /// <summary>
        ///     Adds an execution to this target that generates github actions workflows based on the supplied arguments
        /// </summary>
        /// <returns></returns>
        public TTarget GeneratesGitHubActionsWorkflow(Action<GitHubActionsRoot> builder)
        {
            var originalName = target.Name;
            target.Name = $"GenerateWorkflow_{originalName}";

            var workflow = new GitHubActionsRoot
            {
                name = originalName.Kebaberize()
            };

            builder(workflow);
            var serialized = GitHubActionsSerialization.Serialize(workflow);
            var filePath = Path.Combine(
                IBuildContext.RepositoryRootDirectory,
                ".github",
                "workflows",
                $"{workflow.name}.yml"
            );

            return target.Executes(async (IFileSystem fileSystem) =>
                {
                    var file = fileSystem.FileInfo.New(filePath);

                    var directory = file.Directory!;
                    if (!directory.Exists)
                    {
                        directory.Create();
                    }

                    await using var stream = new StreamWriter(file.Create());
                    await stream.WriteAsync(serialized);
                },
                $$"""
                  Generates github workflow in {{filePath}}:
                  {{serialized}}
                  """
            );
        }
    }

    extension(Job job)
    {
        /// <summary>
        ///     Adds an execution to this target that generates github actions workflows based on the supplied arguments
        /// </summary>
        /// <returns></returns>
        public Job AddStepsFromTargets(Func<ITarget> target, params string[] args) => job.AddStepsFromTargets([target], args);
        
        /// <summary>
        ///     Adds an execution to this target that generates github actions workflows based on the supplied arguments
        /// </summary>
        /// <returns></returns>
        public Job AddStepsFromTargets(Func<ITarget>[] targets, params string[] args)
        {
            var resolvedTargets = targets.StringJoin(t => t().Name, " ");

            var name = $"Execute Targets: {resolvedTargets}";
            var buildProjPath = Path.Combine(IBuildContext.CurrentDirectory.Replace(IBuildContext.RepositoryRootDirectory, "."), "build", "build.csproj");
            var script = $"dotnet run --verbosity q --project {buildProjPath} -- {resolvedTargets} {args.StringJoin(" ")}";
            var steps = new[]
            {
                CommonStepHelper.AddCheckoutStep(fetchDepth: "0"), CommonStepHelper.AddScriptStep(name, script)
            };

            job.steps = (job.steps ?? []).Concat(steps).ToArray();
            return job;
        }
    }
}