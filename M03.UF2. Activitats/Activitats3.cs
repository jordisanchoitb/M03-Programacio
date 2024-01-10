/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 3. Implementa un programa que retorni 
 * el valor absolut d'un nombre introduït per teclat.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSGProgram = "Introdueix un numero i et retorno el seu valor absolut";
            int usernumber;
            Console.WriteLine(MSGProgram);
            usernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El seu valor absolut es: " + AbsoluteNumber(usernumber));

        }

        public static int AbsoluteNumber(int num)
        {
            return num < 0 ? num * -1 : num;
        }
    }
}