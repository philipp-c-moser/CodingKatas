using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    class FizzBuzzHandlerTests
    {
        private FizzBuzzHandler _fizzBuzzHandler;

        private int _numberDivisibleByThree;
        private int _numberDivisibleByFive;
        private int _numberDivisibleByThreeAndFive;


        [SetUp]
        public void SetUp()
        {
            _fizzBuzzHandler = new FizzBuzzHandler();

            _numberDivisibleByThree = 36;
            _numberDivisibleByFive = 55;
            _numberDivisibleByThreeAndFive = 15;
        }


    }
}
