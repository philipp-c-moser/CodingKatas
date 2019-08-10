using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            
            var amount = Convert.ToInt32(Console.ReadLine());

            var fizzBuzzString = fizzBuzz.ConvertNumbersToFizzBuzz(amount);


            foreach (var item in fizzBuzzString)
            {
                Console.WriteLine(item);
            }


        }
    }
}