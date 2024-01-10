/* 
    Autor: Jordi Sancho
    Data: 23/10/2023
    1. Implementa un programa que demani a l’usuari tres números i 
    mostri per pantalla quin dels tres és més gran o si són iguals.
    Important! Ha d’informar quin número és el més petit (ordre d’entrada, no el valor introduït).
 */

using System;

namespace PrimeraProvaPractica
{
    class SanchoJordiEx1
    {
        static void Main()
        {
            int number1, number2, number3;
            const string MSGStartProgram = "Donem 3 numeros i et dic quin dels tres es mes gran o si son iguals";
            const string MSGFirstBigNumber = "El més gran és el primer número";
            const string MSGSecondBigNumber = "El més gran és el segon número";
            const string MSGThreeBigNumber = "El més gran és el tercer número";
            const string MSGSameNumbers = "Els 3 numeros son iguals";

            Console.WriteLine(MSGStartProgram);
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());

            /* Comprovo si els 3 numeros son iguals si no vaig provan totes les opcions posibles */
            if (number1 == number2 && number1 == number3)
            {
                Console.WriteLine(MSGSameNumbers);
            } else if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine(MSGFirstBigNumber);
            } else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine(MSGSecondBigNumber);
            } else 
            { 
                Console.WriteLine(MSGThreeBigNumber);
            }
        }
    }
}




