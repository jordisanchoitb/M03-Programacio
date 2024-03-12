/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 


 */
using System;
using System.Collections.Generic;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            string userinput1, userinput2;
            Console.WriteLine("Enter a date in the format (dd,mm,yyyy)");
            userinput1 = Console.ReadLine();
            Console.WriteLine("Enter a segond date in the format (dd,mm,yyyy)");
            userinput2 = Console.ReadLine();
            Console.WriteLine($"Han passat: {ComparableDate(userinput1, userinput2)} dias.");

        }

        public static string ComparableDate(string date1, string date2)
        {
            string[] infodate1 = date1.Split(',');
            string[] infodate2 = date2.Split(',');
            int days, month, year;

            days = Convert.ToInt32(infodate1[0]);
            month = Convert.ToInt32(infodate1[1]);
            year = Convert.ToInt32(infodate1[2]);
            DateOnly dateuser1 = new DateOnly(year,month,days);

            days = Convert.ToInt32(infodate2[0]);
            month = Convert.ToInt32(infodate2[1]);
            year = Convert.ToInt32(infodate2[2]);
            DateOnly dateuser2 = new DateOnly(year, month, days);

            if (dateuser1 < dateuser2)
            {
                return "La segona data es posterior a la primera.";
            }
            else
            {
                return "La segona data no es posterior a la primera.";
            }
        }
    }
}
