using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public static class NumberGenerator
    {

        public static IEnumerable<int> GenerateNumbers()
        {
            return Enumerable.Range(1, 100);
        }


    }
}