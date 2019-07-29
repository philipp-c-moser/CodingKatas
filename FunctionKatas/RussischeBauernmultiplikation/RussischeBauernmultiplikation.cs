using System;
using System.Collections.Generic;
using System.Text;

namespace RussischeBauernmultiplikation
{
    public class RussischeBauernmultiplikation
    {

        public int Multiplicate(int factor1, int factor2)
        {
            if (factor1 == null || factor2 == null)
            {
                throw new ArgumentNullException();
            }

            var valuesToSumUp = 0;

            do
            {
                if (factor1 % 2 != 0)
                {
                    valuesToSumUp = valuesToSumUp + factor2;
                }

                factor1 = factor1 / 2;
                factor2 = factor2 * 2;

            } while (factor1 >= 1);

            return valuesToSumUp;
        }

    }
}


