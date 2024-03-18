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
        public delegate int RaizCuadrada(int arraynumbers);
        public static void Main()
        {
            RaizCuadrada raizCuadrada = Methods.RaizCuadrada;

            Console.WriteLine("La raiz cuadrada de 16 es: " + raizCuadrada(16));


        }
    }
}
