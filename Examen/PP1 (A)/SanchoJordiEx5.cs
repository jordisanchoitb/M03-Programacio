/* 
    Autor: Jordi Sancho
    Data: 23/10/2023
    5. Implementa un programa que demani a l’usuari 5 números per teclat. El programa retornarà la mitjana de tots aquests nombres.
 */

using System;

namespace PrimeraProvaPractica
{
    class SanchoJordiEx5
    {
        static void Main()
        {
            const int zero = 0;
            double number, mitjana, divmitjana = 5, sumnumbers = 0;
            const string MSGStartProgram = "Donem un numero i et torno els numeros del 1 fins el nombre que mas introduit (El valor introduit a de ser mes gran que 1):";
            const string MSGResult = "La mitjana es: ";

            Console.WriteLine(MSGStartProgram);

            /* Demano el usuari 5 nombres i faig la suma d'ells */
            for (int i = zero; i < divmitjana; i++)
            {
                number = Convert.ToDouble(Console.ReadLine());
                sumnumbers += number;
            }
            mitjana = sumnumbers / divmitjana;
            Console.WriteLine(MSGResult + mitjana);
        }
    }
}




