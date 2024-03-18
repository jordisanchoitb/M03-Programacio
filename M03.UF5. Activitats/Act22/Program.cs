/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 

 */
using System;

namespace OOPEx
{
    public class Program
    {
        public delegate void IsEven(int number);
        public static void Main()
        {
            Console.WriteLine("Introdueix un numero");
            IsEven IsEvent;
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                IsEvent = new IsEven(Methods.Even);
            }
            else
            {
                IsEvent = new IsEven(Methods.Odd);
            }
            IsEvent(number);

        }
    }
}
