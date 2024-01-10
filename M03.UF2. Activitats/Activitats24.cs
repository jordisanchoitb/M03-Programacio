/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * Exercici 24. Implementa un programa que demani dos valors per teclat i calculi el seu producte, seguint el mètode rus (multiplicació per duplicació). S’ha d’implementar:
mètode iteratiu
mètode recursiu

 */

using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "Introdueix dos valors per teclat i et calculo el seu producte, seguint el mètode rus (multiplicació per duplicació).";
            const string MsgFirstValue = "Introdueix el primer valor: ";
            const string MsgSecondValue = "Introdueix el segon valor: ";
            const string MsgResultMult = "El resultat amb el metode (Multiplicacio amb bucle) és: {0}";
            const string MsgResultRecur = "El resultat amb el metode (Amb recursivitat) és: {0}";

            Console.WriteLine(MsgWelcome);
            Console.WriteLine(MsgFirstValue);
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgSecondValue);
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(MsgResultMult, RussianMultiplication(firstValue, secondValue));
            Console.WriteLine(MsgResultRecur, RussianMultiplicationRecursive(firstValue, secondValue));
        }

        public static int RussianMultiplication(int firstValue, int secondValue)
        {
            int result = 0;
            while (firstValue > 0)
            {
                if (firstValue % 2 != 0)
                {
                    result += secondValue;
                }
                firstValue /= 2;
                secondValue *= 2;
            }
            return result;
        }

        public static int RussianMultiplicationRecursive(int firstValue, int secondValue)
        {
            if (firstValue == 0)
            {
                return 0;
            }
            else if (firstValue % 2 == 0)
            {
                return RussianMultiplicationRecursive(firstValue / 2, secondValue * 2);
            }
            else
            {
                return RussianMultiplicationRecursive(firstValue / 2, secondValue * 2) + secondValue;
            }
        }
    }
}