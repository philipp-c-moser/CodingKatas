using System;

namespace WordWrap
{
    class Program
    {
        static void Main(string[] args)
        {
            WordWrap wordWrap = new WordWrap();

            Console.WriteLine("Word Wrap - Function Kata");

            Console.WriteLine("Please insert a Sentence, you want to wrap:");
            var textInput = Console.ReadLine();


            Console.WriteLine("Thank you. Please specify the amount of letters before wrapping:");
            var maxLengthInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(wordWrap.Wrap(textInput, maxLengthInput));

            Console.ReadKey();
        }
    }
}