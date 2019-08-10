using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            

            var fizzBuzzString = fizzBuzz.ConvertNumbersToFizzBuzz();


            foreach (var item in fizzBuzzString)
            {
                Console.WriteLine(item);
            }


        }
    }
}