using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseWords
{
    public class ReverseWordsHandler
    {

        public string GetReverseWord(string word)
        {
            return string.Join(" ", word.Split(' ').Reverse());
        }

    }
}
