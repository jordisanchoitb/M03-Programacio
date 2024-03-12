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
            string userinput;
            Console.WriteLine("Enter a date in the format (dd,mm,yyyy)");
            userinput = Console.ReadLine();
            Console.WriteLine($"Han passat: {DaysPass(userinput)} dias.");

        }

        public static int DaysPass(string date)
        {
            string[] infodate = date.Split(',');
            int days, month, year;
            days = Convert.ToInt32(infodate[0]);
            month = Convert.ToInt32(infodate[1]);
            year = Convert.ToInt32(infodate[2]);

            DateOnly dateuser = new DateOnly(year,month,days);

            DateOnly datetimenow = DateOnly.FromDateTime(DateTime.Now);
            
            if (dateuser > datetimenow)
            {
                return 0;
            } else if (dateuser.Day > datetimenow.Day)
            {
                return (dateuser.Day - datetimenow.Day) + ((datetimenow.Year - dateuser.Year) * 365);
            } else
            {
                return (datetimenow.Day - dateuser.Day) + ((datetimenow.Year - dateuser.Year) * 365);
            }
        }
    }
}
