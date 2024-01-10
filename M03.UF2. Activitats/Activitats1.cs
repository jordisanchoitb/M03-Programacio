/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 1. Crea un programa que demani dos nombres per teclat i validi 
 * si aquests són naturals. Un cop validats, haurà d’indicar quin dels dos nombres és més gran o si tots dos són iguals.
 * 
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Msg1 = "Introdueix un numero";
            const string Msg2 = "Introdueix un altre numero";
            int num1, num2;
            Console.WriteLine(Msg1);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Msg2);
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El primer numero introduit es natural? {(IsPositive(num1) ? "SI" : "NO")}");
            Console.WriteLine($"El segon numero introduit es natural? {(IsPositive(num2) ? "SI" : "NO")}");
            Bigger(num1, num2);
        }
        public static bool IsPositive(int num)
        {
            return num > 0;
        }

        public static void Bigger(int num1, int num2)
        {
            const string MSGEquals = "Els dos nombres son iguals";
            const string MSGBigger = "EL numero {0} es el mes gran dels dos.";

            if (num1 == num2) 
            { 
                Console.WriteLine(MSGEquals);
            }
            else if (num1 > num2)
            {
                Console.WriteLine(MSGBigger, num1);
            } else 
            {
                Console.WriteLine(MSGBigger, num2);
            }
        }
    }
}