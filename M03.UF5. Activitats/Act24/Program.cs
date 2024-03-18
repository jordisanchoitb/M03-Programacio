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
        public delegate bool IsNatural(int number);
        public static void Main()
        {
            IsNatural isNatural = new IsNatural(Methods.IsNatural);
            Console.WriteLine(isNatural(5));
            Console.WriteLine(isNatural(10));
            Console.WriteLine(isNatural(-5));
            Console.WriteLine(isNatural(-10));
        }
    }
}
