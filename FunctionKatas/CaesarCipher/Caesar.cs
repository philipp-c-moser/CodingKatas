using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CaesarCipher
{
    public class Caesar
    {
        private List<char> _plainList;
        private List<char> _shiftedList;

        public Caesar(int shifting)
        {
            _plainList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZß1234567890.,-;:_?=)(/&%$§#+*'~\"!\\ ".ToList();
            _shiftedList = new List<char>();
            GenerateDecryptionList(shifting);
        }


        // TODO: Refactor and use Delegates?
        public string GetEncryptedString(string toEncrypt)
        {
            var sb = new StringBuilder();

            foreach (var item in ProceedEncoding(toEncrypt, _plainList, _shiftedList))
            {
                sb.Append(item);
            }

            return sb.ToString();
        }

        // TODO: Refactor and use Delegates?
        public string GetDecryptedString(string toDecrypt)
        {
            var sb = new StringBuilder();

            foreach (var item in ProceedEncoding(toDecrypt, _shiftedList, _plainList))
            {
                sb.Append(item);
            }

            return sb.ToString();
        }



    

        private List<char> ProceedEncoding(string toEncode, IList<char> positionList, IList<char> proceedList)
        {
            var returnList = new List<char>();
            var encodingList = toEncode.ToList();

            foreach (var item in encodingList)
            {
                var position = positionList.IndexOf(item);
                returnList.Add(proceedList[position]);
            }

            return returnList;
        }



        private void GenerateDecryptionList(int shifting)
        {

            for (var i = 0; i < (_plainList.Count - shifting); i++)
            {
                _shiftedList.Add(_plainList[i + shifting]);
            }

            for (var j = 0; j < shifting; j++)
            {
                _shiftedList.Add(_plainList[j]);
            }

        }


    }
}
