/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 11. Implementa un programa que demani un valor per teclat i retorni el seu factorial.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            ulong usernumber;
            Console.WriteLine("Donem un numero");
            usernumber = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"El factorial es: {Factorial(usernumber)}");

        }
        public static ulong Factorial(ulong number)
        {
            ulong result = 1;

            for (ulong i = 1; i <= number;i++)
            {
                result *= i;
            }
            return result;
        }
    }
}