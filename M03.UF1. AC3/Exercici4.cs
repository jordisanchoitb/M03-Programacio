/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 8/11/2023
 * Exercici 4. Implementa un programa que generi un array, indicant la seva mida per teclat. L’usuari haurà d’indicar un número 
 * per teclat, de manera que els valors de cada posició seran nombres múltiples consecutius 
 * del valor introduït per teclat. Per exemple, si es defineix un array de grandària 5 i s’indica un 3 com a valor,
 * l’array contindrà els valors 3, 6, 9, 12, 15.
 *
 */
using System;

namespace Exercici4
{
    class Exercici4
    {
        static void Main()
        {
            const string MSGProgram = "Donem la mida de l'array i un numero i et guardare dins l'array nombres múltiples consecutius del numero posat.";
            const string MSGGetSizeArray = "Introdueix la mida de l'array: ";
            const string MSGGetUserNumber = "Introdueix el número: ";
            const string MSGArray = "Els valors que hi han dins l'array son: ";

            Console.WriteLine(MSGProgram);
            Console.WriteLine(MSGGetSizeArray);
            int mida = Convert.ToInt32(Console.ReadLine());
            Console.Write(MSGGetUserNumber);
            int numero = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[mida];

            for (int i = 0; i < mida; i++)
            {
                array[i] = numero * (i + 1);
            }
            Console.WriteLine(MSGArray);
            foreach (int i in array)
            {
                Console.Write($"{i}  ");
            }
        }
    }
}

