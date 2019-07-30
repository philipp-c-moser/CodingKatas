using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace DecimalToRoman.Test
{

    [TestFixture]
    class DecimalToRomanTests
    {
        private DecimalToRoman _decimalToRoman;
        private Dictionary<int, char> _numbers;



        [SetUp]
        public void SetUp()
        {
            _decimalToRoman = new DecimalToRoman();
            _numbers = new Dictionary<int, char>
            {
                { 1000, 'M' },
                { 500, 'D' },
                { 100, 'C' },
                { 50, 'L' },
                { 10, 'X' },
                { 5, 'V' },
                { 1, 'I' }
            };
        }

        [Test]
        public void ConvertDecimalToRoman_SetMatchingNumbersFromDictionary_ReturnCorrectValue()
        {
            foreach (var item in _numbers)
            {
                Assert.That(_decimalToRoman.ConvertDecimalToRoman(item.Key), Is.EqualTo(item.Value.ToString()));
            }
        }

        [Test]
        public void ConvertDecimalToRoman_Convert11ToRoman_ReturnCorrectRomanValue()
        {
            var result = _decimalToRoman.ConvertDecimalToRoman(11);

            Assert.That(result, Is.EqualTo("XI"));
        }

    }
}
