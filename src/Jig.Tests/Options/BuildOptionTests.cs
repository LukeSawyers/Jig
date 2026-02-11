using System.CommandLine;
using AwesomeAssertions;
using Jig.Lang;
using Jig.Options;

namespace Jig.Tests.Options;

public class BuildOptionTests
{
    private BuildOption<bool> Option { get; } = new(false, "BoolOption");
    private RootCommand Command => field ??= new RootCommand().Apply(c => c.Add(Option.Option));

    [Fact]
    public void BoolOptionSet_WithFlagSupplied_SetsValue()
    {
        // Arrange
        var parseResult = Command.Parse("--bool-option");

        // Act
        Option.Set(parseResult);

        // Assert
        Option.Value.Should().BeTrue();
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
            Environment.SetEnvironmentVariable("BOOL_OPTION", envVarValue);

            // Act
            Option.Set(parseResult);

            // Assert
            Option.Value.Should().BeTrue();
        }
        finally
        {
            Environment.SetEnvironmentVariable("BOOL_OPTION", null);
        }
    }

    [Fact]
    public void BoolOptionSet_WithNothingSupplied_FallsBackToDefault()
    {
        // Arrange
        var parseResult = Command.Parse("");

        // Act
        Option.Set(parseResult);

        // Assert
        Option.Value.Should().BeFalse();
    }
}