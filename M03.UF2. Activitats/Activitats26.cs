/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 9/1/2024
 * Exercici 26. Implementa un mètode que, donat un nombre natural, calculi de manera recursiva la suma dels seus dígits.
 */

using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "Introdueix un nombre natural i et calculo la seva suma dels seus digits: ";
            const string MsgError = "Error, no has introduit un nombre natural.";
            const string MsgResult = "La suma es: {0}";

            Console.WriteLine(MsgWelcome);
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine(MsgError);
            }
            else
            {
                Console.WriteLine(MsgResult, SumaDigits(num));
            }
        }

        public static int SumaDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }
            else
            {
                return num % 10 + SumaDigits(num / 10);
            }
        }

        public static int Decimalbinary(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return (num % 2 + 10 * Decimalbinary(num / 2));
            }
        }
    }
}