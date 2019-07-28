using System;

namespace Tannenbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            Tannenbaum tannenbaum = new Tannenbaum();

            Console.WriteLine("Tannenbaum - Function Kata");
            Console.WriteLine("Bitte gibt die Anzahl der Reihen an:");
            var input = Convert.ToInt32(Console.ReadLine());

            tannenbaum.PrintTannenbaum(input);



            Console.ReadKey();
        }
    }
}
