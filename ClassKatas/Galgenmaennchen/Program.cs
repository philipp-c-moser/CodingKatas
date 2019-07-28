using System;
using System.Text;

namespace Galgenmaennchen
{
    class Program
    {
        private static Galgenmaennchen _galgenmaennchen;



        static void Main(string[] args)
        {
            _galgenmaennchen = new Galgenmaennchen("Entwurfsmuster");

            _galgenmaennchen.StartGuessing();

            Console.WriteLine("Anzahl Runden: " + _galgenmaennchen.GetNumberOfRounds());

            Console.ReadKey();
        }
    }
}