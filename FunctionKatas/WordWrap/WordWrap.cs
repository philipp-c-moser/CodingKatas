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

            for (var i = 0; i < length; i = i + maxLength)
            {
                var item = text.Substring(i, maxLength);

                outputString.Append(item);
                outputString.Append("\n");
            }

            return outputString.ToString();

        }


    }
}
