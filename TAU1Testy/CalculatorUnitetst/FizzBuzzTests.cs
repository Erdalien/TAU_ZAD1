using System;
using NUnit;
using NUnit.Framework;
using TAU1Testy;

namespace CalculatorUnitetst
{
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_WhenInputIsDivisbleOnlyBy3_ReturnFizz()
        {

            var fizzbuzz = new Calculator();

            var result = fizzbuzz.GetOutput(27);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_WhenInputIsDivisbleOnlyBy5_ReturnBuzz()
        {

            var fizzbuzz = new Calculator();

            var result = fizzbuzz.GetOutput(35);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_WhenInputIsDivisbleBy3And5_ReturnFizzBuzz()
        {

            var fizzbuzz = new Calculator();

            var result = fizzbuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}
