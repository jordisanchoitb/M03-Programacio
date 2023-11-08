/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 8/11/2023
 * Exercici 5. Implementa un programa que generi una matriu de 4x4 i mostri la diagonal principal
 * (pots inicialitzar-la amb els valors enters que consideris).
 */
using System;

namespace Exercici5
{
    class Exercici5
    {
        static void Main()
        {
            const string MSGDiagonal = "La diagonal principal de la matriu és: ";

            int[,] matriu = {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            Console.WriteLine($"{MSGDiagonal}");

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{matriu[i, i]} ");
            }
        }
    }
}

