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
            List<string> ciutats = new List<string> { "ROMA", "LONDRES", "NAIROBI", "CALIFÒRNIA", "ZURICH", "NOVA DELHI", "AMSTERDAM", "ABU DHABI", "PARÍS" };

            string lletreinicial = "A";
            string lletrefinal = "M";

            var ciutatsFiltrades = from ciutat in ciutats
                                   where ciutat.StartsWith(lletreinicial) && ciutat.EndsWith(lletrefinal)
                                   select ciutat;

            foreach (var ciutat in ciutatsFiltrades)
            {
                Console.WriteLine($"La ciutat que comença amb {lletreinicial} i acaba amb {lletrefinal} és: {ciutat}");
            }
        }
    }
}
