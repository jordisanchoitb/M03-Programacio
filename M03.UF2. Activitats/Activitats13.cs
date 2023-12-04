/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 28/11/2023
 * 13. Implementa un algorisme que demani 20 nombres enters per 
 * teclat i retorni els valors de  les posicions senars.

 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSGProgram = "Introdueix 20 numeros:";
            Console.WriteLine(MSGProgram);
            PositionOdd();
        }
        public static void PositionOdd()
        {
            const int arraynumbers = 20;
            int[] numbers = new int[arraynumbers];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

        }
    }
}