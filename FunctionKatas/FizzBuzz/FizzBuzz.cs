﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        

        public static List<string> ConvertNumbersToFizzBuzz()
        {
            return NumberGenerator.GenerateNumbers().Select(ConvertNumberToFizzBuzz).ToList();
        }


        public static string ConvertNumberToFizzBuzz(int number)
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



        private static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsFizzBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

    }
}