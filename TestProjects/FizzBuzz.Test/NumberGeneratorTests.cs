using System;
using System.Collections.Generic;
using System.Linq;
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


        [Test]
        public void GenerateNumbers_Passed100_Return100Numbers()
        {
            var result = _numberGenerator.GenerateNumbers(100);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(100));

        }

        [Test]
        public void GenerateNumbers_Passsed100_ReturnUniqueNumbers()
        {
            var result = _numberGenerator.GenerateNumbers(100);

            Assert.That(result, Is.Unique);
        }

    }
}
