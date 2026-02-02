# Jig Shell

## Overview

Provides a utility to directly invoke shell commands using and bash-like syntax, and `ITarget` extensions 
to add these as invocations. 

## Usage

### Configuring

Call `.AddShell()` when constructing the build to make shell execution available to the build.

### Basic Usage

Call `.Executes()` on a target with the command string:

```csharp
ITarget Target => field ??= new Target()
    .Executes(
        $"ENV_VAR1=val1 dotnet build Solution.sln --verbosity {Verbosity.Value}", 
        ShellLoggingOptions.StandardError
    );
```

This will add an execution to the target to invoke the specified process from the application working directory 
using the environment variables and arguments supplied in the string. The command executed, standard output, and standard error
will be logged to the available `ITargetLogger` depending on the `ShellLoggingOptions` provided. By default all logging 
options are enabled.

### Shell Execution

Commands can be executed in shells instead of process invocation: 

- `ExectutesBash`: Runs the command using bash
- `ExectutesZsh`: Runs the command using zsh
- `ExectutesDash`: Runs the command using dash/sh
- `ExectutesAsh`: Runs the command using BusyBox ash
- `ExectutesPowerShell`: Runs the command using powershell/pwsh
- `ExectutesNativeShell`: Runs the command using the default shell depending on the OS and environment

### DotNet Tool Execution

Call `ExecutesDotNetTool()` on a target specifying the dotnet tool to call and arguments to supply to it:

```csharp
ITarget Target => field ??= new Target()
    .ExecutesDotNetTool($"jetbrains.resharper.globaltools cleanupcode Solution.sln"));

// > dotnet tool exec -y --allow-roll-forward --ignore-failed-sources jetbrains.resharper.globaltools -- cleanupcode Solution.sln"
```

This command definition will be transformed into a `dotnet tool exec` command running the tool with the targets 
supplied, running the tool with the specified arguments.

### Manual Invocation

A `Shell` singleton instance is injected into the build on configuration. This can be resolved using normal execution 
and used for more complex calls: 

```csharp
ITarget Target => field ??= new Target()
    .Executes((Shell shell) => 
    {
        var output = await shell
            .Command($"ENV_VAR1=val1 dotnet build Solution.sln --verbosity {Verbosity.Value}")
            .ExecuteAndCaptureOutputAsync(buildContext.StoppingToken)
            .ToArrayAsync()
        
        // Process output
    });
```

### Argument Redaction

Arguments can be redacted in logs by specifying :redacted in the argument format.
 
```csharp
ITarget Target => field ??= new Target()
    .Executes($"dotnet nuget push --api-key {ApiKey:redacted}");

// > dotnet nuget push --api_key [REDACTED]
```

Sensitive `BuildOption`s are always redacted. 

```csharp
BuildOption<string> ApiKey { get; } = new("--api-key", sensitive: true)


ITarget Target => field ??= new Target()
    .Executes($"dotnet nuget push --api-key {ApiKey}");

// > dotnet nuget push --api_key [REDACTED]
```
 