# xBuild Apt

## Overview

Provides `ITarget` extensions to enforce and assist with apt package dependencies.

## Usage

Call `.RequireAptPackage()` on a target ensure that the specified packages are installed.

```csharp
public ITarget CountLines => field ??= new Target(description: "Counts lines of code")
    .RequireAptPackage("cloc")
    .Executes($"cloc . --include-lang=C#");
```

If the packages aren't installed and user interaction is enabled, the user will be prompted to install
the packages.
 