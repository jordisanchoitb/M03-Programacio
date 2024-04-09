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
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10 };
            var countcaracters = from c in ints
                                 group c by c into g
                                 select new { Caracter = g.Key, Count = g.Count() , Mult = g.Count() * g.Key};
            foreach (var item in countcaracters)
            {
                Console.WriteLine(item.Caracter + " - " + item.Count + " - " + item.Mult);
            }
        }
    }
}
