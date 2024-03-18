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
        public delegate int PowerNumber(int number, int power);
        public static void Main()
        {
            PowerNumber powerNumber = new PowerNumber(Methods.PowerNumber);
            Console.WriteLine(powerNumber(2, 3));
            
        }
    }
}
