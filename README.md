# Tactical NUKE

**Tactical NUKE** task-based build automation system built with .NET, 
based on the incredible work on [NUKE Build](https://github.com/nuke-build/nuke) 
by Matthias Koch and contributors. Tactical NUKE aims to follow the same objectives
as NUKE with a greater emphasis on lower footprint, portability, and extensibility.


## Getting Started

Create a new console application:

```shell
dotnet new console -n _build
```

Add the package:

```shell
dotnet add package TacticalBuild
```

```xml
<PackageReference Include="TacticalBuild" Version="X.Y.Z"/>
```

Add Targets:

```csharp
public class BuildTargets
{
    public const string SolutionPath = "TacticalNuke.sln";

    // System.CommandLine options supported
    public BuildOption<string> Verbosity { get; } = new(
        "normal",
        new Option<string>("--dotnet-verbosity")
        {
            Description = "Verbosity for dotnet tasks"
        }
    );

    // Targets specified as lazily evaluated properties
    private ITarget Build => field ??= new Target(description: "Builds the solution")
        // Targets able to directly execute bash-like commands with shell execution
        .Executes($"""
                   dotnet build {SolutionPath} 
                   --verbosity {Verbosity.Value}
                   """);

    private ITarget Test => field ??= new Target(description: "Tests the solution")
        // Specify the relative ordering of targets
        .After(Build)
        .Executes($"""
                   dotnet test {SolutionPath} 
                   --verbosity {Verbosity.Value}
                   """);

    private ITarget MergeCheck => field ??= new Target(description: "Runs required merge checks")
        // Targets can trigger execution of other targets
        .Triggers(Build, Test);
}

// Multiple target classes supported
public class InspectionTargets(
    ILoggerFactory loggerFactory,
    ) // Class dependency injection supported
{
    private ITarget RestoreDotnetTools => field ??= new Target(description: "Restores dotnet tools")
        // Don't show the target in the CLI
        .Unlisted()
        .Executes("dotnet tool restore --verbosity minimal");

    private ITarget Cleanup => field ??= new Target(description: "Cleans up code")
        .TriggersAfter(RestoreDotnetTools)
        .Executes($"dotnet jb cleanupcode {BuildTargets.SolutionPath}");

    private ITarget Inspect => field ??= new Target(description: "Inspects code")
        .TriggersAfter(RestoreDotnetTools)
        .After(Cleanup)
        // Targets support delegate execution with dependency injection
        .Executes(async (Shell shell) =>
        {
            var logger = loggerFactory.CreateLogger(nameof(Inspect));
            
            // Run shell executions in targets
            var logContents = await shell
                .Execute($"dotnet jb inspectcode {BuildTargets.SolutionPath} -stdout")
                .ToArrayAsync()
                .LetAsync(lines => lines.StringJoin(Environment.NewLine));
            
            // Sarif format serialization provided separately by Sarif.Sdk
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = SarifContractResolverVersionOne.Instance
            };

            var log = JsonConvert.DeserializeObject<SarifLog>(logContents, settings);
            var results = log?.Runs
                .SelectMany(r => r.Results)
                .ToArray() ?? [];
            
            logger.LogInformation(
                "Inspect Results: {Warnings} Warnings {Errors} Errors",
                results.Count(r => r.Level == FailureLevel.Warning),
                results.Count(r => r.Level == FailureLevel.Error)
            );
        });
}
```
Program.cs:
```csharp
// Initialise the build with cli args and the target working directory, relative to folder containing .git
await new TacticalNukeBuild(args, workingDirectory: "src")
    .AddGitLab() // Gitlab Specific Extensions
    // Add target classes to make their targets and CLI options available
    .AddTargets<BuildTargets>()
    .AddTargets<InspectionTargets>()
    // Execute
    .ExecuteAsync();
```

Then run!:

```shell
dotnet run --project _build/_build.csproj -- {args}

Description:
  TACTICAL NUKE INCOMING - Announcer, 2009
  
  Targets:
    Build : Builds the solution
    Test : Tests the solution
    MergeCheck : Runs required merge checks -> [Build, Test]
    Cleanup : Cleans up code -> [RestoreDotnetTools]
    Inspect : Inspects code -> [RestoreDotnetTools]

Usage:
  _build [<targets>...] [options]

Arguments:
  <targets>  Targets to run in the build

Options:
  -s, --skip <skip>                      Targets to skip in the build
  --dotnet-verbosity <dotnet-verbosity>  Verbosity for dotnet tasks
  -?, -h, --help                         Show help and usage information
  --version                              Show version information
```

## Goals

### C# Build Engine
NUKE's C# first target execution engine permits the power and rich ecosystem to be leveraged directly 
for build automation unlike *AKE-like build systems. Tactical NUKE preserves this design goal and functionality.

### Sustainable Architecture
Tactical NUKE aims to ensure long-term maintainability, and in order to ensure this some initial directions 
have been taken:

#### Extensibility Over Integration

At it's core, Tactical NUKE aims to be an extensible execution engine instead of a bundle of functionality. 
No _specific_ support for any tooling is provided in core packages, although integration extensions for 
common tools may be included as non-core packages in this repository. On the other hand, _almost_ every 
aspect of the core should be extendable. 

#### CLI Tool Invocation

Tactical NUKE will **not** attempt to provide CLI bindings for tools. While this approach can improve tool
discoverability, the amount of code required to effectively wrap all possible CLIs can easily become 
unmanageable, and it affects portability with simple scripting and other build systems. 

Instead, **seamless, bash like command invocation** is implemented as an alternative:

```csharp
ITarget Target => field ??= new Target()
    .Executes("ENV1=val1 ENV2=val2 tool --with-args");
```
