# Jig Shell

## Overview

Provides `ITarget` extensions to wrap target delegates in Polly resilience policies.

## Usage

Call `.WithResilience()` on a target to wrap the previously defined execution with the specified policy.

```csharp
ITarget Target => field ??= new Target()
    .Executes($"dotnet build Solution.sln --verbosity {Verbosity.Value}")
    .WithResilience(builder => builder
        .AddRetry(new RetryStrategyOptions { MaxRetryAttempts = int.MaxValue })
        .AddTimeout(TimeSpan.FromSeconds(30))
    )
```

## Acknowledgements

Made possible by [Polly](https://github.com/App-vNext/Polly)