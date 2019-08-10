using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    class FizzBuzzTests
    {

        [Test]
        public void ConvertNumberToFizzBuzz_PassNumberDivisibleByThree_ReturnFizz()
        {
            var result = FizzBuzz.ConvertNumberToFizzBuzz(27);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void ConvertNumberToFizzBuzz_PassNumberDivisibleByFive_ReturnBuzz()
        {
            var result = FizzBuzz.ConvertNumberToFizzBuzz(25);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void ConvertNumberToFizzBuzz_PassNumberDivisibleByThreeAndFive_ReturnFizzBuzz()
        {
            var result = FizzBuzz.ConvertNumberToFizzBuzz(30);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void ConvertNumberToFizzBuzz_PassNumberNotDivisibleByThreeAndFive_ReturnNumberAsString()
        {
            var result = FizzBuzz.ConvertNumberToFizzBuzz(11);

            Assert.That(result, Is.EqualTo("11"));
        }


    }
}
