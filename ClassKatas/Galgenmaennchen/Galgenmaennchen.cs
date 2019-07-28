using System;
using System.Collections.Generic;
using System.Text;

namespace Galgenmaennchen
{
    public class Galgenmaennchen
    {

        private readonly string _searchedWord;
        private int _rounds;
        private List<string> _guessWord;

        public Galgenmaennchen(string searchedWord)
        {
            _searchedWord = searchedWord;
            _guessWord = new List<string>();
            _rounds = 0;

            for (int i = 0; i < _searchedWord.Length; i++)
            {
                _guessWord.Add("-");
            }
        }

        public void StartGuessing()
        {
            while (IsSolved() == false)
            {
                Console.WriteLine("Bitte gib einen Buchstaben ein:");

                var input = "";

                var tempInput = Console.ReadLine();

                if (tempInput != "")
                {
                    input = tempInput.Substring(0, 1);
                }


                Console.WriteLine(GuessLetter(input));
            }
        }

        public int GetNumberOfRounds()
        {
            return this._rounds;
        }


        private string GuessLetter(string letter)
        {
            _rounds++;

            foreach (var position in GetAllPositionsOfLetter(letter))
            {
                _guessWord[position] = letter;
            }

            return GenerateStringFromGuessedWord();
        }

        private bool IsSolved()
        {
            // TODO: If GuessWord does have a "-" to guess, the Galgenmaennchen will never be solved!
            return _guessWord.IndexOf("-") == -1;
        }


        private List<int> GetAllPositionsOfLetter(string letter)
        {
            var positions = new List<int>();


            for (var i = 0; i < _searchedWord.Length; i++)
            {
                if (_searchedWord.Substring(i, 1) == letter)
                {
                    positions.Add(i);
                }
            }

            return positions;
        }


        private string GenerateStringFromGuessedWord()
        {
            var sb = new StringBuilder();

            foreach (var letter in _guessWord)
            {
                sb.Append(letter);
            }

            return sb.ToString();
        }

    }
}
