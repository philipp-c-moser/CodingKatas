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

        public Caesar()
        {
            _plainList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZß1234567890.,-;:_?=)(/&%$§#+*'~\"!\\ ".ToList();
            _shiftedList = new List<char>();
            GenerateDecryptionList(8);
        }


        public string GetEncryptedString(string toEncrypt)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Encrypt(toEncrypt))
            {
                sb.Append(item);
            }

            return sb.ToString();
        }




        private List<char> Encrypt(string toEncrypt)
        {
            List<char> encryptionList = new List<char>();
            List<char> plainList = toEncrypt.ToList();

            int position;

            foreach (var item in plainList)
            {
                position = _plainList.IndexOf(item);
                encryptionList.Add(_shiftedList[position]);
            }

            return encryptionList;
        }



        private void GenerateDecryptionList(int shifting)
        {

            for (int i = 0; i < (_plainList.Count - shifting); i++)
            {
                _shiftedList.Add(_plainList[i + shifting]);
            }

            for (int j = 0; j < shifting; j++)
            {
                _shiftedList.Add(_plainList[j]);
            }

        }


    }
}
