using System;
using Xunit;
using Moq;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var a = 3.0;
            var b = 4.0;
            
            // Act
            var result = _calculator.Add(a, b);
            
            // Assert
            Assert.Equal(a + b, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            var a = 7.0;
            var b = 2.0;
            
            // Act
            var result = _calculator.Subtract(a, b);
            
            // Assert
            Assert.Equal(a - b, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange
            var a = 5.0;
            var b = 6.0;
            
            // Act
            var result = _calculator.Multiply(a, b);
            
            // Assert
            Assert.Equal(a * b, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            // Arrange
            var a = 10.0;
            var b = 2.0;
            
            // Act
            var result = _calculator.Divide(a, b);
            
            // Assert
            Assert.Equal(a / b, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            var a = 10.0;
            var b = 0.0;
            
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Fact]
        public void Divide_NegativeNumber_ReturnsQuotient()
        {
            // Arrange
            var a = 10.0;
            var b = -5.0;
            
            // Act
            var result = _calculator.Divide(a, b);
            
            // Assert
            Assert.Equal(a / b, result);
        }
    }
}