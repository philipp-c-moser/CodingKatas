using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    class FizzBuzzTests
    {

        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }
        


        [Test]
        public void ConvertNumberToFizzBuzz_PassNumberDivisibleByThree_ReturnFizz()
        {
            var result = _fizzBuzz.ConvertNumberToFizzBuzz(27);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void ConvertNumberToFizzBuzz_PassNumberDivisibleByFive_ReturnBuzz()
        {
            var result = _fizzBuzz.ConvertNumberToFizzBuzz(25);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void ConvertNumberToFizzBuzz_PassNumberDivisibleByThreeAndFive_ReturnFizzBuzz()
        {
            var result = _fizzBuzz.ConvertNumberToFizzBuzz(30);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void ConvertNumberToFizzBuzz_PassNumberNotDivisibleByThreeAndFive_ReturnNumberAsString()
        {
            var result = _fizzBuzz.ConvertNumberToFizzBuzz(11);

            Assert.That(result, Is.EqualTo("11"));
        }


    }
}
