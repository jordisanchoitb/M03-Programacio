/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 8/11/2023
 * Exercici 2. Donada la següent llista:
 * a = [10,20,30,20,10,50,60,40,80,50,40]
 * implementa un programa que retorni una llista sense els elements duplicats.
 *
 */
using System;

namespace Exercici2
{
    public class Exercici2
    {
        public static void Main()
        {
            const string MSGCase = "La llista es:";

            int[] array = {10, 20, 30, 20, 10, 50, 60, 40, 80, 50, 40};
            Console.Write(MSGCase);
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    array[i + 1] = 0;
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] != 0)
                {
                    Console.Write($" {array[j]}");
                }
            }
        }
    }
}

