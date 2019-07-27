using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzHandler fizzBuzzHandler = new FizzBuzzHandler();

            Console.WriteLine("FizzBuzz - FunctionKata");

            Console.WriteLine("Please enter the amount of numbers, you want to generate:");

            var amount = Convert.ToInt32(Console.ReadLine());



            var fizzBuzzString = fizzBuzzHandler.StartFizzBuzz(amount);

            foreach (var fizzBuzz in fizzBuzzString)
            {
                Console.WriteLine(fizzBuzz);
            }



            Console.ReadKey();

        }
    }
}