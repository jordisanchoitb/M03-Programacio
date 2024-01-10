/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 8.   Implementa un programa que demani per teclat un nombre 
 * natural i retorni si aquest és un nombre primer o no.
 * Aclariment: Els números 0 i 1 no són primers.
 *
 */

using System;

namespace numberprime
{
    public class numberprime
    {
        public static void Main()
        {
            int usernumber, num=2;
            bool isprime = true;
            const string MSGprogram = "Donem un numero natural i et retorno si el numero es primer o no: ";
            const string MSGnumberprimo = "Es un nombre primer";
            const string MSGnumbernoprimo = "No es un nombre primer";
            
            Console.WriteLine(MSGprogram);
            usernumber = Convert.ToInt32(Console.ReadLine());
            switch (usernumber)
            {
                case 0:
                case 1:
                    isprime = false;
                    break;
                default:
                    while (num < usernumber && isprime)
                    {
                        if (usernumber % num == 0)
                            isprime = false;
                        else
                            num++;
                    }
                    break;

            }
            if (isprime)
            {
                Console.WriteLine(usernumber + ", " + MSGnumberprimo);
            } else
            {
                Console.WriteLine(usernumber + ", " + MSGnumbernoprimo);
            }
        }
    }
}