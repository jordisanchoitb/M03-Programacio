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
            List<string> fitxers = new List<string> { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            var extensions = from fitxer in fitxers
                             let extensio = fitxer.Substring(fitxer.LastIndexOf('.') + 1)
                             group fitxer by extensio.ToLower() into g
                             select new { Extension = g.Key, Count = g.Count() };

            foreach (var ext in extensions)
            {
                Console.WriteLine("{0} fitxers amb extensió .{1}", ext.Count, ext.Extension);
            }
        }
    }
}
