using System;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWordsHandler reverseWordsHandler = new ReverseWordsHandler();

            Console.WriteLine("Reverse Words - Functional Kata");

            Console.WriteLine("Please write a sentence to reverse:");
            var input = Console.ReadLine();

            var reverseWord = reverseWordsHandler.GetReverseWord(input);

            Console.WriteLine(reverseWord);


            Console.ReadKey();
        }
    }
}
