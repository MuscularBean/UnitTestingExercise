using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(9, 12, 24, 45)]
        [InlineData(3, 1, 4, 8)]
        [InlineData(100, 9, 21, 130)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here
                //Arrange
                Calculator challenge = new Calculator();

                //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = challenge.Add(num1, num2, num3);

                //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(6, 3, 3)]
        [InlineData(24, 8, 16)]
        [InlineData(89, 2, 87)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator challenge = new Calculator();
            //Act
            var actual = challenge.Sub(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 12)]
        [InlineData(122, 122, 14884)]
        [InlineData(12, 2, 24)]
        [InlineData(-2, 2, -4)]
        //Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challenge = new Calculator();
            //Act
            var actual = challenge.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(8, 2, 4)]
        [InlineData(0, 2, 0)]
        [InlineData(0, 2, 0)]
        [InlineData(-12, 6, -2)]
        //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenge = new Calculator();
            //Act
            var actual = challenge.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
