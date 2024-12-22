using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 10, -5)] //Add test data <-------
        [InlineData(9, 4, 5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Substract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2, 5, 10)] //Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            var cal = new Calculator();
            //Arrange
            var actual = cal.multiply(num1, num2);
            //Act
            Assert.Equal(expected, actual);
            //Assert

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 2, 10)] //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var cal = new Calculator();
            //Arrange
            var actual = cal.Divide(num1, num2);
            //Act
            Assert.Equal(expected, actual);

        }

    }
}