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
            string text = "cadenadetext";
            var countcaracters = from c in text
                                 group c by c into g
                                 select new { Caracter = g.Key, Count = g.Count() };
            foreach (var item in countcaracters)
            {
                Console.WriteLine(item.Caracter + " - " + item.Count);
            }
        }
    }
}
