using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingTrainingApp.Test
{
    [TestClass]
    public class CalculatorTest
    {
        // Positive Test Case
        [TestMethod]
        public void VerifyAddMethodShouldReturnSumOfTwoNumber()
        {
            // Arrange
            Calculator objCalculator = new Calculator();
            // Act
            int result = objCalculator.Add(10, 20);
            // Assert
            Assert.AreEqual(30, result);
        }

        // Negative Test Case
        [TestMethod]
        public void VerifyAddMethodShouldNotReturnZeroIfBothNumberAreGreaterThanZero()
        {
            // Arrange
            Calculator objCalculator = new Calculator();
            // Act
            int result = objCalculator.Add(10, 20);
            // Assert
            Assert.AreNotEqual(0, result);
        }
    }
}

