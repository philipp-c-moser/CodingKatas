using System;
using System.Collections.Generic;
using System.Text;

namespace WordWrap
{
    class WordWrap
    {


        public string Wrap(string text, int maxLength)
        {
            var length = text.Length;
            var outputString = new StringBuilder();

            for (var i = 0; i <= length; i = i + maxLength)
            {
                var item = "";
                if (IsRestInTextAvailable(length, i, maxLength))
                {
                    item = text.Substring(i, maxLength);
                }
                else
                {
                    item = text.Substring(i, length - i);
                }

                outputString.Append(item);
                outputString.Append("\n");
            }

            return outputString.ToString();
        }


        private bool IsRestInTextAvailable(int length, int startValue, int maxLength)
        {
            return length - (startValue + maxLength) >= 0;
        }


    }
}
