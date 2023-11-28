/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 6. Implementa un programa que retorni el valor absolut 
 * d'un nombre introduït per teclat, utilitzant
 * un dels mètodes implementats en la API de .Net. 
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            Console.WriteLine("Donem un numero y et retorno el seu valor absolut: ");
            int usernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AbsoluteNumber(usernumber));
        }

        public static int AbsoluteNumber(int num)
        {
            return Math.Abs(num);
        }
    }
}