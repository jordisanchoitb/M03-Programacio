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
        public delegate int MediaArray(int[] arraynumbers);
        public static void Main()
        {
            int[] arraynumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MediaArray media = new MediaArray(Methods.Media);
            Console.WriteLine(media(arraynumbers));
            
        }
    }
}
