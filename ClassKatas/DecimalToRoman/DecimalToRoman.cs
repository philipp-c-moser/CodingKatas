using System;
using System.Collections.Generic;
using System.Text;

namespace DecimalToRoman
{
    public class DecimalToRoman
    {

        private readonly Dictionary<int, char> _numbers = new Dictionary<int, char>
        {
            { 1, 'I' },
            { 5, 'V' },
            { 10, 'X' },
            { 50, 'L' },
            { 100, 'C' },
            { 500, 'D' },
            { 1000, 'M' }
        };

        public DecimalToRoman()
        {

        }


        public string ConvertDecimalToRoman(int number)
        {
            var romanNumber = new StringBuilder();
            


            while (number > 0)
            {
                if (number >= _numbers[6])
                {
                    romanNumber.Append(_numbers[6]);
                    number = number - _numbers[6];
                }
                else if (number >= _numbers[5])
                {
                    romanNumber.Append(_numbers[5]);
                    number = number - _numbers[5];
                }
                else if (number >= _numbers[4])
                {
                    romanNumber.Append(_numbers[4]);
                    number = number - _numbers[4];
                }
                else if (number >= _numbers[3])
                {
                    romanNumber.Append(_numbers[3]);
                    number = number - _numbers[3];
                }
                else if (number >= _numbers[2])
                {
                    romanNumber.Append(_numbers[2]);
                    number = number - _numbers[2];
                }
                else if (number >= _numbers[1])
                {
                    romanNumber.Append(_numbers[1]);
                    number = number - _numbers[1];
                }
                else if (number >= _numbers[0])
                {
                    romanNumber.Append(_numbers[0]);
                    number = number - _numbers[0];
                }
            }



            return romanNumber.ToString();
        }



    }
}