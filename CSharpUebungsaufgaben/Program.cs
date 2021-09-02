using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpUebungsaufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("==== Lösungen zu den C Übungsaufgaben ====");
                Console.WriteLine("1: Überladung");
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D0:
                        break;
                }
            }

        }
    }
}
