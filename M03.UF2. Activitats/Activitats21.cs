/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 14/12/2023
 * 21. Implementa un programa que demani un nombre romà i retorni el seu valor enter.
 */

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix un nombre romà: ";

            string romanNumber;

            Console.Write(MsgProgram);
            romanNumber = Console.ReadLine().ToUpper();
            
            Console.WriteLine("El nombre romà {0} és {1} en nombre enter.", romanNumber, RomanToNumber(romanNumber));
        }

        public static int RomanToNumber(string romanNumber)
        {
            int number = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                int currentVal = RomanNumeralValue(romanNumber[i]);
                int nextVal = (i < romanNumber.Length - 1) ? RomanNumeralValue(romanNumber[i + 1]) : 0;

                if (currentVal > nextVal)
                {
                    number += currentVal;
                }
                else
                {
                    number -= currentVal;
                }
            }
            return number;
        }

        public static int RomanNumeralValue(char romanNumeral)
        {
            switch (romanNumeral)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    Console.WriteLine("El nombre introduït no és vàlid.");
                    return -1;
            }
        }
    }
}