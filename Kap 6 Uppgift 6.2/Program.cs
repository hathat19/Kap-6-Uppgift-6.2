using System;
using System.Collections.Generic;
namespace Uppgift6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //-------------------------------------------

            Console.WriteLine(Störst(9,5));

        }

        /// <summary>
        /// Jämför två tal och returnerar det största. 
        /// </summary>
        /// <param name="tal1"></param>
        /// <param name="tal2"></param>
        /// <returns></returns>
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2) return tal1;
            else return tal2;
        }
    }
}
/*Skapa ett program som innehåller metoden
static int Störst(int tal1, int tal2)
Metoden ska returnera det största talet av tal1 och tal2. Om båda talen är lika stora
så returnerar du det värde som talen har.*/