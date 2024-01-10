/* 
    Autor: Jordi Sancho
    Data: 23/10/2023
    2. Implementa un programa que demani a l’usuari que introdueixi dos números i retorno la suma de tots els valors que hi ha entre ells. Els números introduïts per l’usuari no s’han d’incloure en la suma.
 */

using System;

namespace PrimeraProvaPractica
{
    class SanchoJordiEx2
    {
        static void Main()
        {
            const int one = 1;
            int number1, number2, sumNumbers = 0, bignumber, smallnumber;
            const string MSGStartProgram = "Donem 2 numeros i et retorno la suma de tots els valors que hi ha entre ells:";
            const string MSGResult = "La suma dels valors es: ";

            Console.WriteLine(MSGStartProgram);
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            // comprovo quin dels dos numeros es el gran per poder sumar els valors que hi han entere ells posteriorment

            if (number1 < number2)
            {
                smallnumber = number1;
                bignumber = number2;
            }
            else
            {
                smallnumber = number2;
                bignumber = number1;
            }

            /* sumu 1 perque no compte els numeros que posa el usuari*/
            for (int i = smallnumber + one; i < bignumber; i++)
            {
                sumNumbers += i;
            }
            Console.WriteLine(MSGResult + sumNumbers);
        }
    }
}




