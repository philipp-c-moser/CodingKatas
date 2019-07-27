using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzzHandler
    {

        public string ConvertNumberToFizzBuzz(int number)
        {
            if (IsDivisibleByThree(number) && IsDivisibleByFive(number)) return "FizzBuzz";
            if (IsDivisibleByThree(number)) return "Fizz";
            if (IsDivisibleByFive(number)) return "Buzz";

            return Convert.ToString(number);
        }



        private bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        private bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

    }
}
