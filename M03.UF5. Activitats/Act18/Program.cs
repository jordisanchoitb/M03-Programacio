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
        public delegate int[] OrderArray(int[] array);
        public static void Main()
        {
            int[] array = { 5, 3, 2, 1, 4 };
            OrderArray orderArray = Methods.OrderArray;
            int[] orderedArray = orderArray(array);
            foreach (int i in orderedArray)
            {
                Console.Write(i + " ");
            }
            
        }
    }
}
