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
            List<char> list = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            

            Console.WriteLine("Abans de eliminar la o: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Elimina(ref list, 'o');
            Console.WriteLine("Despres de eliminar la o: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void Elimina(ref List<char> list, char eliminatechar)
        {
            list = list.Where(x => x != eliminatechar).ToList();
        }
    }
}
