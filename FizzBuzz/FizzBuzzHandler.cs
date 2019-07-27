using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzzHandler
    {

        private bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        private bool IsDivisibleByFivev(int number)
        {
            return number % 5 == 0;
        }

    }
}
