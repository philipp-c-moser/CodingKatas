using System;

namespace Tannenbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            Tannenbaum tannenbaum = new Tannenbaum();

            Console.WriteLine("Tannenbaum - Function Kata");

            tannenbaum.PrintTannenbaum(5);



            Console.ReadKey();
        }
    }
}
