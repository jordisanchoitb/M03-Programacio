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
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var filteredList = from number in list
                               where number > 80
                               select number;

            foreach (var number in filteredList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
