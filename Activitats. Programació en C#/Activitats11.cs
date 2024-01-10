/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 11. Implementa un programa que retorni si un nombre introduït per teclat és palíndrom o no.
 *
 */

using System;

namespace PalindromeNumber
{
    public class PalindromeNumber
    {
        public static void Main()
        {
            int usernumber, lengthnumber = 0, firstDigit, lastDigit, divider=1;
            bool ispalindrome = true;
            Console.WriteLine("Donem un numero i et dire si és palíndrom o no: ");
            usernumber = Convert.ToInt32(Console.ReadLine());

            for (int i = usernumber; i > 0; i /= 10)
            {
                lengthnumber++;
            }

            for (int i = 0; i < lengthnumber - 1; i++)
            {
                divider *= 10;
            }

            for (int i = 0; i < lengthnumber / 2; i++)
            {
                firstDigit = usernumber / divider;
                lastDigit = usernumber % 10;

                if (firstDigit != lastDigit)
                {
                    ispalindrome = false;
                }

                usernumber = (usernumber % divider) / 10;
                divider /= 100;
            }

            if (ispalindrome)
            {
                Console.WriteLine("Es palíndromo.");
            } else 
            {
                Console.WriteLine("No es palíndromo.");
            }
        }
    }
}
