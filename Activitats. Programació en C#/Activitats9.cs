/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 11/10/2023
 * Exercici 9. Implementa un programa que demani un nombre i aquest retorni el seu factorial.
 *
 */

using System;
using System.Net;

namespace FactorialNumber
{
    public class FactorialNumber
    {
        public static void Main()
        {
            int usernumber, factorialnumber=1;
            Console.WriteLine("Donem un numero i et retorno el seu factorial: ");

            usernumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            for (int i = 1; i <= usernumber; i++)
            {
                factorialnumber *= i; 
            }
            Console.WriteLine("El factorial del numero posat es: " + factorialnumber);
        }
    }
}