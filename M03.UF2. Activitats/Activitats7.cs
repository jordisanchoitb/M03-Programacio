/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 7. Implementa un programa que retorni el la potència 
 * d'un nombre introduït per teclat, utilitzant 
 * un dels mètodes implementats en la API de .Net.  
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            double basenumber, powernumber;

            Console.WriteLine("Donem la base i el exponen y et retorno la potencia: ");
            Console.WriteLine("Donem el numero de la base: ");
            basenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donem el numero de l'exponent: ");
            powernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PowerNumber(basenumber, powernumber));
        }
         
        public static double PowerNumber(double basenumber, double power)
        {
            return Math.Pow(basenumber, power);
        }
    }
}