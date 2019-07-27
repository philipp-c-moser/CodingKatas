using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ReverseWords.Test
{
    [TestFixture]
    class ReverseWordsHandlerTests
    {
        private ReverseWordsHandler _reverseWordsHandler;


        [SetUp]
        public void SetUp()
        {
            _reverseWordsHandler = new ReverseWordsHandler();
        }


        [Test]
        public void GetReverseWord_WhenPassSentence_ShouldReturnTrue()
        {
            var inputSentence = "Das sind nicht die Droiden, die Ihr sucht";
            var outputSentence = "sucht Ihr die Droiden, die nicht sind Das";

            var reverse = _reverseWordsHandler.GetReverseWord(inputSentence);

            Assert.That(reverse, Is.EqualTo(outputSentence));
        }

    }
}
