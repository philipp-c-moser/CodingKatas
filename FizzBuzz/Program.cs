using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz - FunctionKata");

            Console.WriteLine("Please enter the amount of numbers, you want to generate:");

            var amountOfNumbers = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey();

        }
    }
}
