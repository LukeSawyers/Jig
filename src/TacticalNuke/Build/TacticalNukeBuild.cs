using System.CommandLine;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TacticalNuke.Commands;
using TacticalNuke.Targets;

namespace TacticalNuke.Build;

public class TacticalNukeBuild
{
    private readonly BuildContext _buildContext;

    private readonly ServiceCollection _services = new();

    public TacticalNukeBuild(
        string[] args,
        string workingDirectory = ""
    )
    {
        Args = args;

        // Add Default Logging
        _services.AddLogging(b => b.AddSimpleConsole(o => { o.SingleLine = true; }));

        // Add Lifetime
        var rootDirectory = new DirectoryInfo(AppContext.BaseDirectory);
        while (true)
        {
            if (rootDirectory is null)
            {
                throw new ArgumentNullException(nameof(rootDirectory));
            }

            if (rootDirectory.EnumerateDirectories().Any(d => d.Name == ".git"))
            {
                break;
            }

            rootDirectory = rootDirectory.Parent;
        }

        rootDirectory = new DirectoryInfo(Path.Combine(rootDirectory.FullName, workingDirectory));

        var stoppingToken = new CancellationTokenSource();
        Console.CancelKeyPress += (_, _) => stoppingToken.Cancel();
        _buildContext = new BuildContext(rootDirectory, stoppingToken.Token);
        _services.AddSingleton<IBuildContext>(_buildContext);

        // Add Shell
        _services.AddSingleton<Shell>();
    }

    public string[] Args { get; }

    public IServiceCollection Services => _services;

    public TacticalNukeBuild AddService<T>() where T : class
    {
        _services.AddSingleton<T>();
        return this;
    }

    public TacticalNukeBuild AddService<TService, TImplementation>()
        where TService : class
        where TImplementation : class, TService
    {
        _services.AddSingleton<TService, TImplementation>();
        return this;
    }

    /// <summary>
    ///     Add targets contained specified as static fields in <typeparamref name="T" />
    /// </summary>
    public TacticalNukeBuild AddTargets<T>() where T : class
    {
        _services.AddSingleton<T>();
        _services.AddSingleton<ITargetsResolver, TargetsResolver<T>>();
        return this;
    }

    public async Task ExecuteAsync()
    {
        _services.AddSingleton(s => s.GetRequiredService<ILoggerFactory>().CreateLogger(""));
        var serviceProvider = _services.BuildServiceProvider();

        var resolvers = serviceProvider.GetServices<ITargetsResolver>().ToArray();

        // Set up options
        var targetsDescription = resolvers
            .SelectMany(r => r.Targets)
            .Where(t => !t.Unlisted)
            .StringJoin(t =>
            {
                var str = $"  {t.Name} : {t.Description}";
                var triggersTargets = t.Triggers
                    .Where(t => !t.Unlisted)
                    .Select(t => t.Name)
                    .ToArray();

                if (triggersTargets.Length != 0)
                {
                    str += $" -> [{triggersTargets.StringJoin(", ")}]";
                }

                str += Environment.NewLine;

                return str;
            });

        var rootDescription =
            $"""
             TACTICAL NUKE INCOMING - Announcer, 2009

             Targets:
             {targetsDescription}
             """;

        var rootCommand = new RootCommand(rootDescription);
        var targetArgument = new Argument<IEnumerable<string>>("targets")
        {
            Description = "Targets to run in the build",
            Arity = ArgumentArity.ZeroOrMore
        };
        var skipOption = new Option<IEnumerable<string>>("--skip", "-s")
        {
            Description = "Targets to skip in the build",
            AllowMultipleArgumentsPerToken = true,
            Arity = ArgumentArity.ZeroOrMore
        };
        var planOption = new Option<bool>("--plan", "-p")
        {
            Description = "Show the targets to be executed without running",
        };
        var planOnlyOption = new Option<bool>("--plan-only", "-po")
        {
            Description = "Only show the targets to be executed without running",
        };
        rootCommand.Arguments.Add(targetArgument);
        rootCommand.Options.Add(skipOption);
        rootCommand.Options.Add(planOption);
        rootCommand.Options.Add(planOnlyOption);

        var options = resolvers
            .SelectMany(r => r.Options)
            .ToArray();

        foreach (var option in options)
        {
            rootCommand.Add(option.Option);
        }

        // Set up command action
        rootCommand.SetAction(async parseResult =>
        {
            var logger = serviceProvider.GetRequiredService<ILogger>();
            
            // Set the value of options in targets classes
            foreach (var option in options)
            {
                option.Set(parseResult);
            }

            var invokedTargets = parseResult.GetValue(targetArgument)?.ToHashSet() ?? [];
            
            var targets = EnumerateTargets(
                resolvers,
                invokedTargets,
                parseResult.GetValue(skipOption)?.ToHashSet() ?? []
            ).ToArray();

            if (parseResult.GetValue(planOption) || parseResult.GetValue(planOnlyOption))
            {
                foreach (var target in targets)
                {
                    logger.LogDebug("Invoking:");
                    var template = invokedTargets.Contains(target.Name)
                        ? " - {Target}"
                        : " - {Target} *";
                    logger.LogDebug(template, target.Name);
                }
            }
            
            // If plan option specified, return here
            if (parseResult.GetValue(planOnlyOption))
            {
                return;
            }

            var failed = false;

            foreach (var target in targets)
            {
                // If a previous target has failed, only run if configured to do so
                if (failed && !target.ExecuteAfterFailure)
                {
                    continue;
                }

                // Run this target
                var success = await RunTarget(logger, serviceProvider, target);
                if (!success)
                {
                    failed = true;
                }
            }
        });

        await rootCommand.Parse(Args).InvokeAsync();
    }

    private IEnumerable<ITarget> EnumerateTargets(
        IEnumerable<ITargetsResolver> resolvers,
        HashSet<string> targets,
        HashSet<string> skip
    )
    {
        // Collect all targets
        var invokedTargets = resolvers
            .SelectMany(r => r.Targets)
            .DistinctBy(t => t.Name)
            .Where(t => targets.Contains(t.Name))
            .Where(t => !skip.Contains(t.Name))
            .ToList();
        
        CollectTargets(invokedTargets.ToArray());

        void CollectTargets(IEnumerable<ITarget> targets)
        {
            foreach (var triggered in targets.SelectMany(t => t.Triggers))
            {
                if (skip.Contains(triggered.Name) || invokedTargets.Contains(triggered))
                {
                    continue;
                }
                
                invokedTargets.Add(triggered);
            }
        }
        
        while (invokedTargets.Count > 0)
        {
            foreach (var target in EnumerateTargets(invokedTargets[0]))
            {
                yield return target;
            }
        }

        IEnumerable<ITarget> EnumerateTargets(ITarget target)
        {
            invokedTargets.Remove(target);
            
            // Run targets scheduled before this target
            foreach (var linkedTarget in target.After)
            {
                if (invokedTargets.Contains(linkedTarget))
                {
                    foreach (var enumerateTarget in EnumerateTargets(linkedTarget))
                    {
                        yield return enumerateTarget;
                    }
                }
            }
            
            yield return target;
        }
    }

    private async Task<bool> RunTarget(
        ILogger logger,
        IServiceProvider serviceProvider,
        ITarget target
    )
    {
        if (target.Execution is not { } execution)
        {
            return true;
        }

        var separatorLine = "║";
        var startEndLine = $"╬{new string(Enumerable.Repeat('=', 50).ToArray())}";

        var sw = Stopwatch.StartNew();
        try
        {
            var args = execution.Method.GetParameters()
                .Select(p => serviceProvider.GetRequiredService(p.ParameterType))
                .ToArray();

            _buildContext.ExecutingTarget = target;
            logger.LogDebug("{Line}", startEndLine);
            logger.LogDebug("{Line}", $"║  {target.Name}");
            logger.LogDebug("{Line}", separatorLine);

            var scopeState = new Dictionary<string, object>
            {
                ["ExecutingTarget"] = target.Name
            };

            using (logger.BeginScope(scopeState))
            {
                var result = execution.DynamicInvoke(args);
                if (result is Task task) await task;
            }

            logger.LogDebug("{Line}", separatorLine);
            logger.LogDebug($"{{Line}} Succeeded {sw.Elapsed.TotalSeconds:F1}s", $"║  {target.Name}");
            logger.LogDebug("{Line}", startEndLine);
            return true;
        }
        catch (Exception e)
        {
            var exception = e is TargetInvocationException ? e.InnerException ?? e : e;
            if (target.ProceedAfterFailure)
            {
                logger.LogWarning(exception, exception.Message);
                logger.LogWarning("{Line}", separatorLine);
                logger.LogWarning($"{{Line}} Failed {sw.Elapsed.TotalSeconds:F1}s", $"║  {target.Name}");
                logger.LogWarning("{Line}", startEndLine);
                return true;
            }

            logger.LogError(exception, exception.Message);
            logger.LogError("{Line}", separatorLine);
            logger.LogError($"{{Line}} Failed {sw.Elapsed.TotalSeconds:F1}s", $"║  {target.Name}");
            logger.LogError("{Line}", startEndLine);
            return false;
        }
    }
}