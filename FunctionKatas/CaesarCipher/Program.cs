using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Caesar caesar = new Caesar();

            Console.WriteLine("Caesar Cipher - Function Kata");

            Console.WriteLine("Welche Zeichenkette möchten Sie verschlüsseln?");

            var input = Console.ReadLine();

            Console.WriteLine(caesar.GetEncryptedString(input));

            Console.ReadKey();
        }
    }
}
