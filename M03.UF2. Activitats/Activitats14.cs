/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 28/11/2023
 * 14.  Implementa un algorisme que donat un nombre introduït per teclat:
calculi quants digits té i ho mostri per pantalla
sumi els dígits amb valor parell (si n’hi han) i mostri el resultat per pantalla
sumi els dígits senars (si n’hi han)  i mostri el resultat per pantalla

 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSGProgram = "Introdueix un numero:";
            int usernumber;
            Console.WriteLine(MSGProgram);
            usernumber = Convert.ToInt32(Console.ReadLine());
            CalcOddEvenNumbers(usernumber);
        }

        public static void CalcOddEvenNumbers(int number)
        {
            const string MsgOdd = "La suma dels digits imparells es: {0}";
            const string MsgEven = "La suma dels digits parells es: {0}";
            int sumdigitodd = 0, sumdigiteven = 0, usernumber = number, lenghtnumber = 1;

            while (usernumber > 10)
            {
                lenghtnumber++;
                usernumber /= 10;
            }
            Console.WriteLine(lenghtnumber);

            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sumdigiteven += digit;
                } else
                {
                    sumdigitodd += digit;
                }
                number /= 10;
            }
            Console.WriteLine(MsgEven,sumdigiteven);
            Console.WriteLine(MsgOdd,sumdigitodd);
        }
    }
}