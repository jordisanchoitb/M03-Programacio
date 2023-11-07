/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 11/10/2023
 * Exercici 10. Implementa un programa que retorni els n primers números de la serie de Fibonacci:
 *
 */

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace fibonaccinumber
{
    public class fibonaccinumber
    {
        public static void Main()
        {
            int usernumber, fibonaccinumber=1, lastfibonaccinumber=0, temporal;
            bool comma = false;

            Console.WriteLine("Cuants primers numeros vols que et retorni de la serie fibonacci: ");

            usernumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");
            
            Console.WriteLine("Els " + usernumber + " primers numeros de la serie fibonacci son:");
            for (int i = 0; i < usernumber; i++)
            {
                if (comma) { Console.Write(", "); }
                Console.Write(lastfibonaccinumber);

                temporal = lastfibonaccinumber;
                lastfibonaccinumber = fibonaccinumber;
                fibonaccinumber = temporal + fibonaccinumber;
                
                comma = true;
            }
            
        }
    }
}