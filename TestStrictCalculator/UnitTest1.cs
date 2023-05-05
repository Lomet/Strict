namespace StrictHandler.Tests;

public class StrictCalculatorTests
{
    [Theory]
    [InlineData(StrictCalculator.Modes.StrictDisabled, true, false)]
    [InlineData(StrictCalculator.Modes.StrictEnabled, true, true)]
    [InlineData(StrictCalculator.Modes.StrictDisabled, false, false)]
    [InlineData(StrictCalculator.Modes.StrictEnabled, false, true)]
    [InlineData(StrictCalculator.Modes.Loose, true, true)]
    [InlineData(StrictCalculator.Modes.Loose, false, false)]
    public void StrictCalculator_CalculatesResultCorrectly(StrictCalculator.Modes mode, bool loose, bool expectedResult)
    {
        // Arrange
        var calculator = new StrictCalculator(mode, loose);

        // Act
        bool result = calculator.Result;

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
