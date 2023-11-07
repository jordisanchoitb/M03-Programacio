/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 6.   Implementa un programa que demani l’any i aquest retorni si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
 *
 */

using System;

namespace LeapYear
{
    public class LeapYear
    {
        public static void Main()
        {
            // impar odd i par even
            const string MSGLeapYear = "Es un any de traspas";
            const string MSGNotLeapYear = "No es un any de traspas";

            int year;
            Console.WriteLine("Donem un any i et retorno si es un any de traspas o no: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine(MSGLeapYear);
            }
            else
            {
                Console.WriteLine(MSGNotLeapYear);
            }
        }
    }
}


