/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 14/12/2023
 * 20. Implementa un programa que donat un nombre decimal introduït per teclat retorni la part entera i la part decimal d’aquest.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix un nombre decimal: ";
            double number;
            Console.Write(MsgProgram);
            number = Convert.ToDouble(Console.ReadLine());
            
            ExtractNumbers(number);
        }

        public static void ExtractNumbers(double usernumber)
        {
            double number = Math.Truncate(usernumber);
            double decimalNumber = usernumber - number;

            Console.WriteLine("La part entera del nombre és: " + number);
            Console.WriteLine("La part decimal del nombre és: " + decimalNumber);
        }
    }
}