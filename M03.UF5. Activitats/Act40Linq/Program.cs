/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 9/4/2024
 * 
 * Exercici x. 

 */
using System;
using System.Linq;
using System.Security.Cryptography;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            List<char> llista = new List<char> { 'm', 'n', 'o', 'p', 'q' };
            Console.WriteLine("Aquesta és la llista d'elements:");
            foreach (char c in llista)
            {
                Console.WriteLine("Caràcter: " + c);
            }
            llista = llista.Where(c => c != 'q').ToList();
            Console.WriteLine("Aquesta és la llista després d'eliminar l'element «q» de la llista :");
            foreach (char c in llista)
            {
                Console.WriteLine("Caràcter: " + c);
            }

            

        }
    }
}
