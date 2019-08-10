using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var fizzBuzzString = FizzBuzz.ConvertNumbersToFizzBuzz();


            foreach (var item in fizzBuzzString)
            {
                Console.WriteLine(item);
            }


        }
    }
}