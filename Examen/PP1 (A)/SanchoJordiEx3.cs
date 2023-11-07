/* 
    Autor: Jordi Sancho
    Data: 23/10/2023
    3. Implementa un programa que mostri la taula de multiplicar d’un número introduït per l’usuari.
 */

using System;

namespace PrimeraProvaPractica
{
    class SanchoJordiEx3
    {
        static void Main()
        {
            const int maxmult = 10, zero=0;
            int number;
            const string MSGStartProgram = "Donem un numero i et torno la seva taula de multiplicar:";

            Console.WriteLine(MSGStartProgram);
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = zero; i <= maxmult; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + number * i);
            }
        }
    }
}
