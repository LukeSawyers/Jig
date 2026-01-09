# xBuild

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
using System.CommandLine;
using TacticalNuke.Targets;

namespace _build.Targets;

// Class dependency injection supported, including referencing other target classes
public class BuildTargets(
    InspectionTargets inspectionTargets
) : IBuildTargets 
{
    public const string SolutionPath = "TacticalNuke.sln";

    // System.CommandLine options supported
    public BuildOption<string> Verbosity { get; } = new(
        "minimal",
        new Option<string>("--dotnet-verbosity")
        {
            Description = "Verbosity for dotnet tasks"
        }
    );

    // Targets specified as lazily evaluated properties. Name inferred and description provided:
    private ITarget Build => field ??= new Target(description: "Builds the solution")
        // Targets able to directly execute bash-like commands with shell execution
        .Executes($"""
                   dotnet build {SolutionPath}
                   --verbosity {Verbosity}
                   """);

    private ITarget Test => field ??= new Target(description: "Tests the solution")
        // Specify the relative ordering of targets
        .After(Build)
        // Command arguments can be redacted with :redact - "dotnet test TacticalNuke.sln --verbosity [REDACTED]"
        .Executes($"""
                   dotnet test {SolutionPath} 
                   --verbosity {Verbosity:redact}
                   """);

    private ITarget MergeCheck => field ??= new Target(description: "Runs required merge checks")
        // Targets can express dependency relationships, triggering execution of other targets
        .DependsOn(
            Build, 
            // Can reference targets defined elsewhere
            inspectionTargets.Inspect,
            Test
        );
}

// Multiple target classes supported
public class InspectionTargets(
    ILoggerFactory loggerFactory,
) : IBuildTargets // Class dependency injection supported
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

## Features

### Target Graph Execution

### CLI Parameters with System.CommandLine

### Simplified Shell Execution

### 

### Extension

#### Dependency Injection

The execution engine uses dependency injection, which can be used to extend the function of the system. Injected
services can be resolved in class constructors, and by target delegates. Targets and build option classes must be
registered as singletons. A scope is created per target execution. 

```csharp
// Program.cs
var build = new TacticalNukeBuild("src")
    .AddTargets<MyTargets>;
build.Services.AddSingleton<IMySingleton, MySingleton>();
build.Services.AddSingleton<IMyScoped, MyScoped>();
await build.ExecuteAsync(args);

// MyTargets.cs
public class MyTargets(IMySingleton singleton) : IBuildTargets
{
    public ITarget Target => field ??= new Target()
        .Executes((IMyScoped scoped) => {})
}
```

#### Logging
A basic `ILoggerFactory` implementation is provided built in, but this can be overriden using dependency injection.

```csharp
// SerilogExtensions.cs
public static class SerilogExtensions
{
    extension(TacticalNukeBuild build)
    {
        public TacticalNukeBuild AddSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .Enrich.FromLogContext()
                .MinimumLevel.Verbose()
                .CreateLogger();

            build.Services.AddLogging(b => b
                .ClearProviders()
                .AddSerilog(Log.Logger));

            return build;
        }
    }
}

// Program.cs
await new TacticalNukeBuild("src")
    .AddSerilog()
    .AddTargets<MyTargets>()
    .ExecuteAsync(args);
```

#### Target Implementation

Targets may be extended. Any class implementing `ITarget` may be used. 
All built in extension methods target `T where T : ITarget`

```csharp
// MyTarget.cs
/// Automatically implements a delegate setting "Executed" to true
public class MyTarget : Target 
{
    public bool Executed { get; }
    
    public MyTarget([CallerMemberName] string name = "") : base(name)
    {
        Executes(() => Executed = true);
    }
}

// MyBuildTargets.cs
public class MyTargets : IBuildTargets
{
    public MyTarget Target => field ??= new MyTarget();
}
```

## Porting from NUKE Build

Tactical NUKE doesn't offer complete coverage of NUKE APIs by design and makes no commitment to support them. 
However, most pipelines can be bridged to without requiring complete rewrites and some extension methods are provided 
to assist in bridging the gap: 

Add the NukeCommon extension package to the build:
```shell
dotnet add package TacticalBuild.NukeCommon
```
```xml
<PackageReference Include="TacticalBuild.NukeCommon" Version="X.Y.Z"/>
```

Targets can be copied near verbatim with minor adjustments, and nuke common tools can be used as normal:

```csharp
ITarget ToolRestore => field ??= new Target()
    ...
    .Executes((BuildContext context) => DotNetTasks.DotNetToolRestore(s => s
        .Configure(context)
    ));
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
