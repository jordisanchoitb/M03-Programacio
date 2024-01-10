/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 28. Fent servir la interpolació i l’operador ternari, implementa un programa que indiqui 
 * pels 20 primers nombres (del 1 al 20 inclosos) si és parell o senar (només ha d’indicar per a cada valor “És parell”/”És senar)”.
 *
 */
using System;

namespace Exercici28
{
    public class Exercici28
    {
        public static void Main()
        {
            const string MSGOdd = "És senar";
            const string MSGNotOdd = "És parell";
            const int nummin = 1, nummax = 20;


            for (int i = nummin; i <= nummax; i++)
            {
                Console.WriteLine($"{i} {(i % 2 == 0 ? MSGNotOdd : MSGOdd)}");
            }
        }
    }
}

