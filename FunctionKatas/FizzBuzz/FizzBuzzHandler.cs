using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzHandler
    {
        private NumberGenerator _numberGenerator;

        public FizzBuzzHandler()
        {
            _numberGenerator = new NumberGenerator();
        }

        public List<string> StartFizzBuzz(int amount)
        {
            var fizzBuzzString = new List<string>();

            foreach (var number in _numberGenerator.GenerateNumbers(amount))
            {
                fizzBuzzString.Add(ConvertNumberToFizzBuzz(number));
            }

            return fizzBuzzString;
        }


        private string ConvertNumberToFizzBuzz(int number)
        {
            if (IsNumberDivisibleByThree(number) && IsNumberDivisibleByFive(number)) return "FizzBuzz";
            if (IsNumberDivisibleByThree(number)) return "Fizz";
            if (IsNumberDivisibleByFive(number)) return "Buzz";

            return Convert.ToString(number);
        }



        public bool IsNumberDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        public bool IsNumberDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

    }
}