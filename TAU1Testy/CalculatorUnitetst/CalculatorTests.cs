using System;
using NUnit;
using NUnit.Framework;
using TAU1Testy;

namespace CalculatorUnitetst
{
    public class CalculatorTests
    {
        [Test]

        public void Add_WhenCalled_ReturnSum()
        {
            var calculator = new Calculator();

            var result = calculator.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [Test]

        public void Substract_WhenCalled_ReturnDifference()
        {
            var calculator = new Calculator();

            var result = calculator.Substract(5, 10);

            Assert.AreEqual(5, result);
        }
        
        [Test]

        public void Multiple_WhenCalled_ReturnQuotient()
        {
            var calculator = new Calculator();

            var result = calculator.Multiple(8, 3);

            Assert.AreEqual(24, result);
        }

        [Test]

        public void Divide_WhenCalled_ReturnProduct()
        {
            var calculator = new Calculator();

            var result = calculator.Divide(3, 12);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Factorial_WhenCalled()
        {
            var calculator = new Calculator();

            var result = calculator.Factorial(5);

            Assert.AreEqual(120, result);
        }
    }
}
