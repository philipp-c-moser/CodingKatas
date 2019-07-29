using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace RussischeBauernmultiplikation.Test
{
    [TestFixture]
    public class RussischeBauernmultiplikationTests
    {
        private RussischeBauernmultiplikation _russischeBauernmultiplikation;


        [SetUp]
        public void SetUp()
        {
            _russischeBauernmultiplikation = new RussischeBauernmultiplikation();
        }

        [Test]
        public void Multiplicate_WithTwoFactors_ReturnCorrectFactor()
        {
            var result = _russischeBauernmultiplikation.Multiplicate(968, 93277);

            Assert.That(result, Is.EqualTo(90292136));
        }


        [Test]
        public void Multiplicate_WithTwoFactorsReverse_ReturnCorrectFactor()
        {
            var result = _russischeBauernmultiplikation.Multiplicate(93277, 968);

            Assert.That(result, Is.EqualTo(90292136));
        }



        [Test]
        public void Multiplicate_SameValue_ReturnCorrectFactor()
        {
            var result = _russischeBauernmultiplikation.Multiplicate(100, 100);

            Assert.That(result, Is.EqualTo(10000));
        }


        [Test]
        public void Multiplicate_OneWithOne_ReturnOne()
        {
            var result = _russischeBauernmultiplikation.Multiplicate(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }






    }
}
