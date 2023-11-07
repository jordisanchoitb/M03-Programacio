/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 15.  Implementa un programa que demani a l’usuari quants valors vol introduir i generi una llista a partir d’aquest valors introduïts per teclat, retornant la suma de tots els elements d’aquesta
 *
 */

using System;

namespace Exercici15
{
    public class Exercici15
    {
        public static void Main()
        {
            const string MSGStartProgram = "Quants valors vols introduir a la llista?: ";
            const string MSGGetNumberList = "Introdueix els nombres que hi hauran a la llista: ";
            const string MSGResult = "La suma es: ";
            int lengtharray, sumnumbers=0;

            Console.WriteLine(MSGStartProgram);
            lengtharray = Convert.ToInt32(Console.ReadLine());
            int[] arraynumbers = new int[lengtharray];

            Console.WriteLine(MSGGetNumberList);
            for (int i = 0; i < lengtharray; i++)
            {
                arraynumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0;j < lengtharray; j++)
            {
                sumnumbers += arraynumbers[j];
            }

            Console.WriteLine(MSGResult+sumnumbers);




        }
    }
}
