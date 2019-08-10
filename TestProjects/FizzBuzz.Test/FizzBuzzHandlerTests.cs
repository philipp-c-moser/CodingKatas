using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    class FizzBuzzHandlerTests
    {
        private FizzBuzz _fizzBuzz;

        private int _numberDivisibleByThree;
        private int _numberDivisibleByFive;
        private int _numberDivisibleByThreeAndFive;


        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();

            _numberDivisibleByThree = 36;
            _numberDivisibleByFive = 55;
            _numberDivisibleByThreeAndFive = 15;
        }





        [Test]
        public void IsNumberDivisibleByThree_WhenPassNumberDivisbleByThree_ReturnTrue()
        {

            var result = _fizzBuzz.IsNumberDivisibleByThree(_numberDivisibleByThree);

            Assert.That(result, Is.True);

        }

        [Test]
        public void IsNumberDivisibleByThree_WhenPassNumberNotDivisbleByThree_ReturnFalse()
        {

            var result = _fizzBuzz.IsNumberDivisibleByThree(_numberDivisibleByFive);

            Assert.That(result, Is.False);

        }


        [Test]
        public void IsNumberDivisibleByFive_WhenPassNumberDivisbleByFive_ReturnTrue()
        {

            var result = _fizzBuzz.IsNumberDivisibleByFive(_numberDivisibleByFive);

            Assert.That(result, Is.True);

        }

        [Test]
        public void IsNumberDivisibleByThree_WhenPassNumberNotDivisbleByFive_ReturnFalse()
        {

            var result = _fizzBuzz.IsNumberDivisibleByFive(_numberDivisibleByThree);

            Assert.That(result, Is.False);

        }


        [Test]
        public void IsNumberDivisibleByThreeAndFive_WhenPassNumberDivisbleByThreeAndFive_ReturnTrue()
        {

            var result = _fizzBuzz.IsNumberDivisibleByFive(_numberDivisibleByThreeAndFive) &&
                         _fizzBuzz.IsNumberDivisibleByFive(_numberDivisibleByThreeAndFive);

            Assert.That(result, Is.True);

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
