using System.CommandLine;
using AwesomeAssertions;
using Jig.Lang;
using Jig.Options;

namespace Jig.Tests.Options;

public class BuildArgumentTests
{
    private BuildArgument<bool> Argument { get; } = new(false, "BoolArg");
    private RootCommand Command => field ??= new RootCommand().Apply(c => c.Add(Argument.Argument));

    [Fact]
    public void BoolOptionSet_WithArgValue_SetsValue()
    {
        // Arrange
        var parseResult = Command.Parse("true");

        // Act
        Argument.Set(parseResult);

        // Assert
        Argument.Value.Should().BeTrue();
    }

    [Theory]
    [InlineData("TRUE")]
    [InlineData("tRuE")]
    [InlineData("true")]
    public void BoolOptionSet_WithEnvironmenVariableSupplied_SetsValue(string envVarValue)
    {
        try
        {
            // Arrange
            var parseResult = Command.Parse("");
            Environment.SetEnvironmentVariable("BOOL_ARG", envVarValue);

            // Act
            Argument.Set(parseResult);

            // Assert
            Argument.Value.Should().BeTrue();
        }
        finally
        {
            Environment.SetEnvironmentVariable("BOOL_ARG", null);
        }
    }

    [Fact]
    public void BoolOptionSet_WithNothingSupplied_FallsBackToDefault()
    {
        // Arrange
        var parseResult = Command.Parse("");

        // Act
        Argument.Set(parseResult);

        // Assert
        Argument.Value.Should().BeFalse();
    }
}