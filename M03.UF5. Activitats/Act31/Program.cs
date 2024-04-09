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
            string[] days = { "Dilluns", "Dimarts", "Dimecres", "Dijous", "Divendres", "Dissabte", "Diumenge" };
            var daysOfWeek = from day in days
                             select day;
            foreach (var item in daysOfWeek)
            {
                Console.WriteLine(item);
            }
        }
    }
}
