/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 13/12/2023
 * 19. Implementa un programa que retorni el màxim i mínim de dos valors enters introduïts per teclat.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix dos valors enters per teclat i et retornaré el màxim i el mínim.";
            const string MsgInputFirstValue = "Introdueix el primer valor: ";
            const string MsgInputSecondValue = "Introdueix el segon valor: ";
            const string MsgMax = "El màxim és: ";
            const string MsgMin = "El mínim és: ";

            Console.WriteLine(MsgProgram);
            Console.Write(MsgInputFirstValue);
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write(MsgInputSecondValue);
            int secondValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgMax + Max(firstValue, secondValue));
            Console.WriteLine(MsgMin + Min(firstValue, secondValue));
        }

        public static int Max(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

        public static int Min(int firstValue, int secondValue)
        {
            if (firstValue < secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}