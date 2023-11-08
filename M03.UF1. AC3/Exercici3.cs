/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 8/11/2023
 * Exercici 3. Implementa un programa que, donada la següent llista, retorni l’element més gran i el més petit.
llista= [5,10,15,2,25,30,35,40]

 *
 */
using System;

namespace Exercici3
{
    class Exercici3
    {
        static void Main()
        {
            const string MSGMaxNumber = "L'element més gran de l'array és: ";
            const string MSGMinNumber = "L'element més petit de l'array és: ";

            int[] array = { 5, 10, 15, 2, 25, 30, 35, 40 };

            int maxim = array[0], minim = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxim)
                {
                    maxim = array[i];
                }

                if (array[i] < minim)
                {
                    minim = array[i];
                }
            }

            Console.WriteLine($"{MSGMaxNumber}{maxim}");
            Console.WriteLine($"{MSGMinNumber}{minim}");
        }
    }
}

