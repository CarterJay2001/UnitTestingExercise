using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 7, 9, 19)]
        [InlineData(5, 2, 25, 32)]
        [InlineData(1, 1, 1, 3)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            int ans = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, ans);
        }

        [Theory]
        [InlineData(30, 17, 13)]
        [InlineData(7, 2, 5)]
        [InlineData(5, 25, -20)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            int ans = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, ans);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(7, 8, 56)]
        [InlineData(10, 20, 200)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            int ans = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, ans);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(100, 5, 20)]
        [InlineData(69, 3, 23)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            int ans = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, ans);
        }

        [Fact]
        public void SayHi()
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            string actual = test.SayHi();

            //Assert
            Assert.Equal("Hi", actual);
        }

        [Fact]
        public void SayBye()
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            string actual = test.SayBye();

            //Assert
            Assert.Equal("Bye", actual);
        }
    }
}
