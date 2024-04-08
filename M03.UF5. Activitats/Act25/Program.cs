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
        public static void Main()
        {
            string text = "9 -abcĐ😀ω\0";
            Console.WriteLine("Cleaned text: " + Identifier.Clean(text));

            
        
        }
    }
}
