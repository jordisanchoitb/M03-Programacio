/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 9/1/2024
 * Exercici 27. Implementa un mètode que determini de manera recursiva si un nombre natural és primer.
 */

using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "Introdueix un nombre natural i et dic si es primer o no: ";
            const string MsgError = "Error, no has introduit un nombre natural.";

            Console.WriteLine(MsgWelcome);
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine(MsgError);
            }
            else
            {
                Console.WriteLine(IsPrime(num) ? $"El nombre {num}, es primer." : $"El nombre {num}, no es primer.");
            }
        }

        public static bool IsPrime(int num)
        {
            if (num == 1)
            {
                return false;
            }
            else if (num == 2)
            {
                return true;
            }
            else
            {
                return IsPrime(num, 2);
            }
        }

        public static bool IsPrime(int num, int div)
        {
            if (num % div == 0)
            {
                return false;
            }
            else if (div < num / 2)
            {
                return IsPrime(num, div + 1);
            }
            else
            {
                return true;
            }
        }
    }
}