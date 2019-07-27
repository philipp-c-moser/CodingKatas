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
        public List<char> _shiftedList;

        public Caesar()
        {
            _plainList = "abcdefghijklmnopqrstuvwxyz".ToList();
            _shiftedList = new List<char>();
            GenerateDecryptionList(8);
        }


        private List<char> Encrypt(string toEncrypt)
        {
            List<char> encryptionList = new List<char>();
            List<char> plainList = toEncrypt.ToList();


            foreach (var item in plainList)
            {

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
