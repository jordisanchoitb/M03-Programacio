/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 16.  Implementa un programa que demani  a l’usuari 10 enters per teclat i els mostri en sentit contrari al que s’ha introduït.
 *
 */

using System;

namespace Exercici16
{
    public class Exercici16
    {
        public static void Main()
        {
            const string MSGStartProgram = "Donem 10 enters per teclat i et mostro en sentit contrari de com els has introduït.?: ";
            const int lengtharray=10, one=1;

            int[] arraynumbers = new int[lengtharray];

            
            Console.WriteLine(MSGStartProgram);
            for (int i = 0; i < lengtharray; i++)
            {
                arraynumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = lengtharray - one; j >= 0; j--)
            {
                Console.Write(arraynumbers[j] + " ");
            }
        }
    }
}
