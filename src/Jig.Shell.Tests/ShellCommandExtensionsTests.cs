using System.Text.Json;
using AwesomeAssertions;
using AwesomeAssertions.Execution;
using CliWrap;
using Jig.Lang;
using Jig.Options;
using Newtonsoft.Json;

namespace Jig.Shell.Tests;

[UsesVerify]
public class ShellCommandExtensionsTests
{
    [Fact]
    public void Redact_RedactsArgumentsWithRedactFormatting()
    {
        // Arrange
        var secret = "Super Secret String";
        FormattableString str = $"I have a {secret:redact}";

        // Act
        var redacted = str.Redact().ToString();
        var notRedacted = str.ToString();

        // Assert
        redacted.Should().BeEquivalentTo("I have a [REDACTED]");
        notRedacted.Should().BeEquivalentTo($"I have a {secret}");
    }

    [Fact]
    public void Redact_RedactsSensitiveBuildOption()
    {
        // Arrange
        var secretValue = "Super Secret String";
        var secret = new BuildOption<string>(secretValue, sensitive: true);
        FormattableString str = $"I have a {secret}";

        // Act
        var redacted = str.Redact().ToString();
        var notRedacted = str.ToString();

        // Assert
        redacted.Should().BeEquivalentTo("I have a [REDACTED]");
        notRedacted.Should().BeEquivalentTo($"I have a {secretValue}");
    }

    [Fact]
    public void ToDotNetToolCommand_WrapsToExpected()
    {
        // Arrange
        var arg = "val";
        FormattableString command = $"ENV1=VAL1 tool --with {arg}";

        // Act
        var dotnetToolCommand = command.ToDotnetToolCommand();

        // Assert
        using var _ = new AssertionScope();
        dotnetToolCommand.Format.Should().Contain("ENV1=VAL1 dotnet tool exec");
        dotnetToolCommand.Format.Should().Contain("tool -- --with {0}");
        var resultArg = dotnetToolCommand.GetArgument(0);
        resultArg.Should().NotBeNull();
        resultArg.Should().Be("val");
    }

    [Fact]
    public void ToUnixShellCommand_WrapsToExpected()
    {
        // Arrange
        var shell = "shell";
        var arg = "val";
        FormattableString command = $"ENV1=VAL1 tool --with {arg}";

        // Act
        var dotnetToolCommand = command.ToUnixShellCommand(shell);

        // Assert
        using var _ = new AssertionScope();
        dotnetToolCommand.Format.Should().Contain($"ENV1=VAL1 /bin/{shell}");
        dotnetToolCommand.Format.Should().Contain("tool --with {0}");
        var resultArg = dotnetToolCommand.GetArgument(0);
        resultArg.Should().NotBeNull();
        resultArg.Should().Be("val");
    }

    [Fact]
    public void ToPowerShellCommand_WrapsToExpected()
    {
        // Arrange
        var arg = "val";
        FormattableString command = $"ENV1=VAL1 tool --with {arg}";

        // Act
        var dotnetToolCommand = command.ToPowerShellCommand();

        // Assert
        using var _ = new AssertionScope();
        dotnetToolCommand.Format.Should().Contain("ENV1=VAL1 /usr/bin/pwsh");
        dotnetToolCommand.Format.Should().Contain("tool --with {0}");
        var resultArg = dotnetToolCommand.GetArgument(0);
        resultArg.Should().NotBeNull();
        resultArg.Should().Be("val");
    }

    [Fact]
    public async Task ExecuteAndCaptureOutput_ReturnsStdOut()
    {
        // Arrange
        var expectedLines = new[]
        {
            "Line1", "Line2"
        };

        // Act
        var output = await Cli.Wrap($"echo")
            .WithArguments(expectedLines.StringJoin(Environment.NewLine))
            .ExecuteAndCaptureOutputAsync(CancellationToken.None)
            .ToArrayAsync();

        // Assert
        output.Should().BeEquivalentTo(expectedLines);
    }

    record TestObject(
        string Key,
        float Value
    );

    private static readonly TestObject TestObj = new("Balance", 1.32f);

    private static readonly string TestJson =
        $$"""
          {
               \"Key\": \"{{TestObj.Key}}\",
               \"Value\": {{TestObj.Value}}
          }
          """;

    [Fact]
    public async Task ExecuteAndCaptureJsonOutputStj_ReturnsDeserialized()
    {
        // Act
        var output = await Cli.Wrap("echo")
            .WithArguments(TestJson)
            .ExecuteAndCaptureJsonOutputAsync<TestObject>(new JsonSerializerOptions(), CancellationToken.None);

        // Assert
        output.Should().BeEquivalentTo(TestObj);
    }
    
    [Fact]
    public async Task ExecuteAndCaptureJsonOutputNewtonsoft_ReturnsDeserialized()
    {
        // Act
        var output = await Cli.Wrap("echo")
            .WithArguments(TestJson)
            .ExecuteAndCaptureJsonOutputAsync<TestObject>(new JsonSerializerSettings(), CancellationToken.None);

        // Assert
        output.Should().BeEquivalentTo(TestObj);
    }
}