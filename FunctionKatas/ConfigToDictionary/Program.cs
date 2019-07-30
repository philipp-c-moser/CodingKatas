using System;

namespace ConfigToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigToDictionary configToDictionary = new ConfigToDictionary();

            Console.WriteLine("Configuration to Dictionary - Function Kata");

            Console.WriteLine("Bitte geben Sie Ihr Konfigurationsfile ein");

            var input = Console.ReadLine();

            Console.WriteLine(configToDictionary.ToString(input));

            Console.ReadKey();
        }
    }
}
