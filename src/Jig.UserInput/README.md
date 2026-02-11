# Jig User Input

## Overview

Provides interfaces and default implementations to allow targets to accept user input.

## Usage

User input methods are defined in `IUserInput`. A default console based implementation is provided. 

Most commonly, user input is not expected in CI pipelines. User input must be enabled with th `Interactive` 
option `--interactive` for these methods to be available. `input.Enabled` property will be true in this case.

Show a message and wait for user input:

```csharp
string result = await input.PromptAsync('Enter value');
````

Request a yes/no confirmation:

```csharp
bool result = await input.PromptBoolAsync('Start microwave?');
````

Listen to user input and pipe it into standard input for a command:

```csharp
await shell.Command($"sudo apt-get install {package}")
    .WithStandardInputPipe(input.CreateInputPipeSource())
    .ExecuteAsync();
````

## Acknowledgements

Made trivial by: [DotNetEnv](https://github.com/Tyrrrz/CliWrap)
