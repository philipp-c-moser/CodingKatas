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


        [SetUp]
        public void SetUp()
        {
            _decimalToRoman = new DecimalToRoman();
        }

    }
}
