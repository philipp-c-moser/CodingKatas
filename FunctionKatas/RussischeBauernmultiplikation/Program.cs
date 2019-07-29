using System;

namespace RussischeBauernmultiplikation
{
    class Program
    {
        static void Main(string[] args)
        {
            RussischeBauernmultiplikation russischeBauernmultiplikation = new RussischeBauernmultiplikation();

            Console.WriteLine("Russische Bauernmultiplikation - Function Kata");

            Console.WriteLine("Bitte geben Sie Faktor 1 an:");
            var factor01 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Bitte geben Sie Faktor 2 an:");
            var factor02 = Convert.ToInt32(Console.ReadLine());


            var result = russischeBauernmultiplikation.Multiplicate(factor01, factor02);

            Console.WriteLine($"Result: {factor01}*{factor02}={result}");
            


            Console.ReadKey();
        }
    }
}
