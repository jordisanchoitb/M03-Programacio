/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 9/4/2024
 * 
 * Exercici x. 

 */
using System;
using System.Linq;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\file.txt");
            int count = lines.Sum(line => line.Length);

            Console.WriteLine($"El fitxer te {count} caracteres i {lines.Length} lineas");

        }
    }
}
