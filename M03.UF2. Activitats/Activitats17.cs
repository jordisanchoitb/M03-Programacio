/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 13/12/2023
 * 17. Implementa un programa que llegeixi graus en escala Celsius (CC) i els converteixi en graus en escala Fahrenheit (FF). 
 * Arrodoneix el resultat a 2 dígits després del punt decimal.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix els graus en Celsius i et diré els graus en Fahrenheit";
            const string MsgResult = "El resultat en Fahrenheit és: {0:N2}";
            double inputuser;

            Console.WriteLine(MsgProgram);
            inputuser = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(MsgResult, ConvertCelsiusToFahrenheit(inputuser));
        }

        public static double ConvertCelsiusToFahrenheit(double inputuser)
        {
            return (inputuser * 9 / 5) + 32;
        }       
    }
}