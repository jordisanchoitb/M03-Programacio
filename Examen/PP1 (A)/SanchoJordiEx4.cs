/* 
    Autor: Jordi Sancho
    Data: 23/10/2023
    4. Implementa un programa mostri els valors desde 1 fins al número introduït per l’usuari.
 */

using System;

namespace PrimeraProvaPractica
{
    class SanchoJordiEx4
    {
        static void Main()
        {
            const int one = 1;
            int number;
            const string MSGStartProgram = "Donem un numero i et torno els numeros del 1 fins el nombre que mas introduit (El valor introduit a de ser mes gran que 1):";
            const string MSGResult = "Els nombres son: ";
            const string MSGcomma = ", ";
            bool comma = false;

            Console.WriteLine(MSGStartProgram);
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MSGResult);
            /* Comprovo els numeros que que hi han entre el 1 i el nombre introduit per el usuari */
            for (int i = one; i <= number; i++)
            {
                if (comma)
                {
                    Console.Write(MSGcomma);
                }
                Console.Write(i);
                comma = true;
            }
        }
    }
}




