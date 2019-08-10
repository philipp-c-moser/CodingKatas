using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        

        public List<string> ConvertNumbersToFizzBuzz(int amount)
        {
            var fizzBuzzString = new List<string>();

            foreach (var number in NumberGenerator.GenerateNumbers(amount))
            {
                fizzBuzzString.Add(ConvertNumberToFizzBuzz(number));
            }

            return fizzBuzzString;
        }


        public string ConvertNumberToFizzBuzz(int number)
        {
            if (IsFizzBuzz(number))
            {
                return "FizzBuzz";
            }

            if (IsFizz(number))
            {
                return "Fizz";
            }

            if (IsBuzz(number))
            {
                return "Buzz";
            }

            return Convert.ToString(number);
        }



        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        private bool IsFizzBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

    }
}