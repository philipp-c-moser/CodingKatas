using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CaesarCipher.Test
{
    [TestFixture]
    class CaesarTests
    {

        private Caesar _caesar;
        private string _plainText;
        private string _encryptedText;


        [SetUp]
        public void SetUp()
        {
            _caesar = new Caesar(8);

            _plainText = "Das sind nicht die Droiden, die Ihr sucht!";
            _encryptedText = "LiAhAqvlhvqkpBhlqmhLzwqlmv(hlqmhQpzhACkpBf";
        }


        [Test]
        public void GetEncryptedString_WhenPassedPlainString_ReturnEncrypted()
        {
            var encryption = _caesar.GetEncryptedString(_plainText);

            Assert.That(encryption, Is.EqualTo(_encryptedText));
        }


        [Test]
        public void GetDecryptedString_WhenPassedEncryptedString_ReturnPlain()
        {
            var decryption = _caesar.GetDecryptedString(_encryptedText);

            Assert.That(decryption, Is.EqualTo(_plainText));
        }

    }
}
