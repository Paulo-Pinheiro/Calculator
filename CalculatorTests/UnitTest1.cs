using System;
using Xunit;
using Calculator;

namespace CalculatorTests
{
    public class UnitTestCalculator
    {
        [Fact]
        public void TestMultiply()
        {
            Assert.Equal(6, Calculator.Calculator.Multiply(2, 3));
        }
    }
}
