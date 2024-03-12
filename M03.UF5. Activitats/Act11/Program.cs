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
            Dictionary<string, int> map = new Dictionary<string, int> { {"Jordi",1000}, {"David", 19999}, {"Qihang", 100} };
            
            foreach (var item in map)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            

        }
    }
}
