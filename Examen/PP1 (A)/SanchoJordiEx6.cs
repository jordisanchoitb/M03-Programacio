/* 
    Autor: Jordi Sancho
    Data: 23/10/2023
    6. Implementa un joc en el que el programa emmagatzemi un nombre i l’usuari hagi d’endevinar-lo. El programa haurà de donar pistes a l’usuari indicant si el nombre que ha introduït és massa alt, massa baix o l’ha encertat. L’usuari disposarà de 5 intents per encertar el número.

 */

using System;

namespace PrimeraProvaPractica
{
    class SanchoJordiEx6
    {
        static void Main()
        {
            const int secretnumber = 500, zero=0;
            int number, maxtrys = 5;
            const string MSGStartProgram = "Intenta Endevinar el numero ocult sol tindras 5 intents, Introdueix un nombre: ";
            const string MSGBig = "Massa baix: ";
            const string MSGSmall = "Massa alt: ";
            const string MSGCorrect = "Molt be has endevinat el nombre ocult. ";
            const string MSGFailed = "No has endevinat el nombre ocult despres de 5 intents. ";

            Console.WriteLine(MSGStartProgram);
            /* Comprovo si els nombres introduits son mes grans o mes petits he informo al usuari */
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > secretnumber)
                {
                    Console.WriteLine(MSGSmall);
                }
                else
                {
                    Console.WriteLine(MSGBig);
                }

                maxtrys--;
            } while (number != secretnumber && maxtrys != zero);
            /* comprovo els intents que a utilitzat per endevinar el nombre secret o en cas de que no els hagui endivinat posarli un misatja dient que no els ha endivinat */
            if (maxtrys == zero)
            {
                Console.WriteLine(MSGFailed);
            }
            else
            {
                Console.WriteLine(MSGCorrect);
            }
        }
    }
}




