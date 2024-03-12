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
            List<int> employees = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"La suma de tots els numeros de la llista es: {employees.Sum()}");

        }
    }
}
