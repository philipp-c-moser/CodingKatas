using System;
using System.Collections.Generic;
using System.Text;

namespace Tannenbaum
{
    class Tannenbaum
    {
        private List<string> _tannenbaumList;

        public Tannenbaum()
        {
            _tannenbaumList = new List<string>();
        }


        public void PrintTannenbaum(int amountOfRows)
        {
            AddRowsToList(amountOfRows);

            foreach (var item in _tannenbaumList)
            {
                Console.WriteLine(item);
            }
        }


        private void AddRowsToList(int amountOfRows)
        {
            for (var i = 1; i <= amountOfRows; i++)
            {
                var sbSpace = new StringBuilder();
                var sbSign = new StringBuilder();

                for (var j = (amountOfRows - (i / 2)); j >= 1; j--)
                {
                    sbSpace.Append(" ");
                }

                for (var k = 1; k <= i; k++)
                {
                    sbSign.Append("X");
                }

                _tannenbaumList.Add(sbSpace.ToString() + sbSign.ToString());

            }
        }



    }
}
