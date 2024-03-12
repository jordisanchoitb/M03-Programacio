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
            string[] strings = new string[] { "hola", "adeu", "patata", "poma" };
            List<string> list = strings.ToList();
            
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }   
        }
    }
}
