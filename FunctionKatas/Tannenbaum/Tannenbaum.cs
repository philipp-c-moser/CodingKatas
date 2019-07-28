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


        // TODO: Add Spacing in front of the Signs
        private void AddRowsToList(int amountOfRows)
        {
            for (var i = 1; i <= amountOfRows; i++)
            {
                var sbSign = new StringBuilder();

                for (var j = 1; j <= i; j++)
                {
                    sbSign.Append("X");
                }

                _tannenbaumList.Add(sbSign.ToString());

            }
        }



    }
}
