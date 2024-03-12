/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 
 * 
 * 
*/
using System.Text.RegularExpressions;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introdueix el teu correu");
            string correu = Console.ReadLine() ?? "patata";
            Console.WriteLine(Ismail(correu) ? "El mail es correcte" : "El mail es incorecte");
        }

        public static bool Ismail(string cadena)
        {
            return Regex.IsMatch(cadena, "^[a-zA-z0-9\\W]+[@][a-zA-z0-9]+[.][a-zA-z0-9]+");
        }
    }
}
