using System;
using NUnit;
using NUnit.Framework;
using TAU1Testy;

namespace CalculatorUnitetst
{
    class FibTests
    {

        [Test]

        public void Fib_WhenCalling()
        {
            var calculator = new Calculator();

            var result = calculator.Fibonacci(5);

            Assert.AreEqual(7, result);
        }
    }
}
