/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 27/11/2023
 * 5. Demanar un nombre per teclat i indicar per 
 * pantalla si aquest nombre és positiu i menor que 100.
 */

using System;
using System.IO.Compression;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSGProgram = "Introdueix un numero";
            int usernumber;
            
            Console.WriteLine(MSGProgram);
            usernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PositiveNumber(usernumber) ? "El numero es positiu i menor que 100" : "El numero no es positiu o el numero no es menor 100");
        }
        public static bool PositiveNumber(int number)
        {
            return number >= 0 && number < 100;
        }
    }
}