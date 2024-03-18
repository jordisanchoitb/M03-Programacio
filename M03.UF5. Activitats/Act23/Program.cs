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
        public delegate int Fibonnaci(int number);
        public static void Main()
        {
            Fibonnaci fib = new Fibonnaci(Methods.Fibonnaci);
                Console.WriteLine("Introduce un número para calcular su número de Fibonacci");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El número Fibonacci de la posició {number} és: {fib(number)}");
        }
    }
}
