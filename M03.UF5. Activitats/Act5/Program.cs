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
            Console.WriteLine(DayOfWeekString(DayOfWeek()));
        }

        public static int DayOfWeek()
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            return (int)date.DayOfWeek;
        }

        public static string DayOfWeekString(int date)
        {
            switch (date)
            {
                case 0:
                    return "Diumenge";
                case 1:
                    return "Dilluns";
                case 2:
                    return "Dimarts";
                case 3:
                    return "Dimecres";
                case 4:
                    return "Dijous";
                case 5:
                    return "Divendres";
                case 6:
                    return "Dissabte";
                default:
                    return "Error";
            }
        }
    }
}
