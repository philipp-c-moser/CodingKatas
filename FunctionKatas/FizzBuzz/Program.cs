using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzHandler fizzBuzzHandler = new FizzBuzzHandler();
            
            var amount = Convert.ToInt32(Console.ReadLine());

            var fizzBuzzString = fizzBuzzHandler.StartFizzBuzz(amount);


            foreach (var item in fizzBuzzString)
            {
                Console.WriteLine(item);
            }


        }
    }
}