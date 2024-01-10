/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 28/11/2023
 * 15. Implementa un programa que demani l’any i aquest retorni si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSGProgram = "Introdueix un any:";
            int usernumber;
            Console.WriteLine(MSGProgram);
            usernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(YearBisiesto(usernumber) ? $"{usernumber} es un año bisiesto." : $"{usernumber} no es un año bisiesto.");
        }

        public static bool YearBisiesto(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 100 == 0 && year % 400 == 0));
        }
    }
}