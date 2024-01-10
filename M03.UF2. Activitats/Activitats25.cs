/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * Exercici 25. Implementa un mètode que calculi de manera recursiva el nombre binari equivalent al valor natural que rep com a paràmetre.
 */

using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "Introdueix un nombre natural i et retorno el seu numero en binari: ";
            const string MsgError = "Error, no has introduit un nombre natural.";
            const string MsgResult = "El nombre en binari es: {0}";

            Console.WriteLine(MsgWelcome);
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine(MsgError);
            }
            else
            {
                Console.WriteLine(MsgResult, ConvertToBinary(num));
            }
        }

        public static string ConvertToBinary(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            else if (num == 1)
            {
                return "1";
            }
            else
            {
                return ConvertToBinary(num / 2) + ConvertToBinary(num % 2);
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