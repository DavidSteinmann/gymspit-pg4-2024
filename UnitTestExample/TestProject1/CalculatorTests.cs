using UnitTestExample;

namespace TestProject1
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            // SUT - system under test
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(7, 2);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers2()
        {
            // Arrange
            // SUT - system under test
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(-4, 8);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers3()
        {
            // Arrange
            // SUT - system under test
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(0, 0);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_ShouldReturnProductOfTwoNumbers()
        {
            var calculator = new Calculator();

            int result = calculator.Multiply(4, 5);

            Assert.Equal(20, result);
        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(0, 468, 0)]
        [InlineData(1, 2783, 2783)]
        [InlineData(-7, 5, -35)]
        public void Multiply_ShouldReturnProduct(int a, int b, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.Multiply(a, b);

            Assert.Equal(expected, result);
        }
    }
}