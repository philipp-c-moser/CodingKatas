using System;

namespace DecimalToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalToRoman decimalToRoman = new DecimalToRoman();
            Console.WriteLine("Decimal to Roman - Class Kata");

            Console.WriteLine("Welche dezimale Ganzzahl möchten Sie in die römische Schreibweise umwandeln?");
            var input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(decimalToRoman.ConvertDecimalToRoman(input));


            Console.ReadKey();
        }
    }
}
