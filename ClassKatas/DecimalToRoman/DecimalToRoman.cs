﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecimalToRoman
{
    public class DecimalToRoman
    {

        private readonly Dictionary<int, char> _numbers = new Dictionary<int, char>
        {
            { 1000, 'M' },
            { 500, 'D' },
            { 100, 'C' },
            { 50, 'L' },
            { 10, 'X' },
            { 5, 'V' },
            { 1, 'I' }
        };

        public DecimalToRoman()
        {

        }


        public string ConvertDecimalToRoman(int number)
        {
            var romanNumber = new StringBuilder();
            


            while (number > 0)
            {
                foreach (var item in _numbers)
                {
                    if (number >= item.Key)
                    {
                        romanNumber.Append(item.Value);
                        number = number - item.Key;
                    }
                }
            }



            return romanNumber.ToString();
        }



    }
}