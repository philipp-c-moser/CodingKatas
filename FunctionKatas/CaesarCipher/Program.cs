using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Caesar caesar = new Caesar(15);

            Console.WriteLine("Caesar Cipher - Function Kata");

            Console.WriteLine("Welche Zeichenkette möchten Sie verschlüsseln?");

            var input = Console.ReadLine();
            var encrypted = caesar.GetEncryptedString(input);

            Console.WriteLine("Encrypted: " + encrypted);
            Console.WriteLine("Decrypted: " + caesar.GetDecryptedString(encrypted));

            Console.ReadKey();
        }
    }
}
