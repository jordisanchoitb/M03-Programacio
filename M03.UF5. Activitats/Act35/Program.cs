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
            string cadena = "this IS a STRING";

            var words = from word in cadena.Split(' ')
                        where word.ToUpper() == word
                        select word;

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
