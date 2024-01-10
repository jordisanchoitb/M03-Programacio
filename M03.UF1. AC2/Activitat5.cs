/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 5.   Implementa un algorisme que donat un nombre introduït per teclat:
- calculi quants digits té i ho mostri per pantalla
- sumi els dígits amb valor parell (si n’hi han) i mostri el resultat per pantalla
- sumi els dígits senars (si n’hi han)  i mostri el resultat per pantalla
 *
 */

using System;

namespace oddandeven
{
    public class oddandeven
    {
        public static void Main()
        {
            // impar odd i par even
            int number, odd = 0, even = 0, lenghNumber = 0, calc, div10 = 10;
            Console.WriteLine("Donem un numero i et retorno quants digits te i el digits parells el sumo entre si al mateix amb els imparells: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 9)
            {
                while (number > 9)
                {
                    calc = number / div10;
                    if (calc % 2 == 0)
                    {
                        even += calc;
                    }
                    else
                    {
                        odd += calc;
                    }
                    lenghNumber++;
                    number /= div10;
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    even += even;
                }
                else
                {
                    odd += odd;
                }
                lenghNumber++;
            }
            Console.WriteLine("Te " + lenghNumber + " digits, la suma del valors parells es " + even + " i la dels valors imparells es: " + odd);
        }
    }
}

