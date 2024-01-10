/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * 1. Implementa un programa que calculi, mitjançant un mètode propi,
 * la suma dels elements d'un array introduïts per teclat.
 */

using System;

namespace Ex1
{
    public class Ex1
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix 5 numerus";
	    const string MsgResult = "La suma dels numerus es: {0}"; 
            Console.WriteLine(MsgProgram);
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(MsgResult , Suma(array));
        }

        public static int Suma(int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            return suma;
        }
    }
}