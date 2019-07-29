using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    class NumberGeneratorTests
    {
        private NumberGenerator _numberGenerator;

        [SetUp]
        public void SetUp()
        {
            _numberGenerator = new NumberGenerator();
        }



    }
}
