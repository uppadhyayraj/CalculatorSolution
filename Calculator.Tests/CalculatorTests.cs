using Xunit;

namespace Calculator.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        double a = 5.0;
        double b = 3.0;
        double expected = 8.0;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        double a = -5.0;
        double b = -3.0;
        double expected = -8.0;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
    {
        // Arrange
        double a = 10.0;
        double b = -4.0;
        double expected = 6.0;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_ZeroAndNumber_ReturnsNumber()
    {
        // Arrange
        double a = 0.0;
        double b = 7.5;
        double expected = 7.5;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_DecimalNumbers_ReturnsCorrectSum()
    {
        // Arrange
        double a = 2.5;
        double b = 3.7;
        double expected = 6.2;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result, precision: 10);
    }

    [Fact]
    public void Add_LargeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        double a = 1000000.0;
        double b = 2000000.0;
        double expected = 3000000.0;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}