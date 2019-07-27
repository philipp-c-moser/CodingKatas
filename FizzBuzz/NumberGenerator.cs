using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class NumberGenerator
    {

        public IEnumerable<int> GenerateNumbers(int amount)
        {
            return Enumerable.Range(1, amount);
        }


    }
}
