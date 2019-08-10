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
        [Test]
        public void GenerateNumbers_WhenCalled_ReturnCorrectList()
        {
            var result = NumberGenerator.GenerateNumbers();
            var assertion = Enumerable.Range(1, 100);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(assertion));

        }

        [Test]
        public void GenerateNumbers_WhenCalled_Return100Numbers()
        {
            var result = NumberGenerator.GenerateNumbers();
            var assertion = Enumerable.Range(1, 100);

            Assert.That(result.Count, Is.EqualTo(assertion.Count()));
        }

        [Test]
        public void GenerateNumbers_WhenCalled_ReturnUniqueNumbers()
        {
            var result = NumberGenerator.GenerateNumbers();

            Assert.That(result, Is.Unique);
        }

    }
}
