using System;
using Xunit;
using Calculator;

namespace CalculatorTest
{
    public class MyCalculatorTest
    {
        private MyCalculator testCalculator = new MyCalculator();
        //Addition testing
        [Fact]
        public void CalculatorShouldAdd()
        {
            int first = 5;
            int second = 5;
            int total = 10;
            Assert.Equal(total, testCalculator.Add(first,second));
        }
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(-2,-8,-10)]
        [InlineData(5,-5,0)]
        public void CanAddTheory(int input1, int input2, int expected)
        {
            int total = testCalculator.Add(input1,input2);
            Assert.Equal(total, expected);
        }
        //Subtraction Testing
        [Fact]
        public void CalculatorShouldSubtract()
        {
            int first = 5;
            int second = 5;
            int total = 0;
            Assert.Equal(total, testCalculator.Subtract(first, second));
        }

        [Theory]
        [InlineData(8,4,4)]
        [InlineData(2,-2,4)]
        [InlineData(-2,2,-4)]
        [InlineData(-2,-2,0)]
        public void CanSubtractTheory(int input1, int input2, int expected)
        {
            Assert.Equal(expected, testCalculator.Subtract(input1,input2));
        }
        //Multiplication testing
        [Fact]
        public void CalculatorShouldMultiply()
        {
            int first = 5;
            int second = 2;
            int total = 10;
            Assert.Equal(total, testCalculator.Multiply(first,second));
        }

        [Theory]
        [InlineData(9,1,9)]
        [InlineData(0,5,0)]
        [InlineData(7,-2,-14)]
        [InlineData(-5,0,0)]
        [InlineData(-2,-5,10)]
        public void CanMultipyTheory(int input1, int input2, int expected)
        {
            Assert.Equal(expected, testCalculator.Multiply(input1, input2));
        }
        //Division Testing
        /*
        [Fact]
        public void CalculatorShouldDivide()
        {
            int first = 10;
            int second = 2;
            int total = 5;
            Assert.Equal(total,testCalculator.Divide(first,second));
        }

        [Theory]
        [InlineData(0,5)]
        [InlineData(5,0)]
        */
    }
}
