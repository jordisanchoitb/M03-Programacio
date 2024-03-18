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
            Console.WriteLine("Act 1 Check what the counts were last week");
            Console.WriteLine(BirdCount.LastWeek());
            Console.WriteLine();

            Console.WriteLine("Act 2 Check how many birds visited today");
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            BirdCount birdCount = new BirdCount(birdsPerDay);
            Console.WriteLine("Birds today: " + birdCount.Today());
            Console.WriteLine();

            Console.WriteLine("Act 3 Increment today's count");
            birdsPerDay = [2, 5, 0, 7, 4, 1];
            birdCount = new BirdCount(birdsPerDay);
            birdCount.IncrementTodaysCount();
            Console.WriteLine("Birds today: " + birdCount.Today());
            Console.WriteLine();

            Console.WriteLine("Act 4 Check if there was a day with no visiting birds");
            birdsPerDay = [2, 5, 0, 7, 4, 1];
            birdCount = new BirdCount(birdsPerDay);
            Console.WriteLine("Has day without birds: " + birdCount.HasDayWithoutBirds());
            Console.WriteLine();

            Console.WriteLine("Act 5 Calculate the number of visiting birds for the first number of days");
            birdsPerDay = [2, 5, 0, 7, 4, 1];
            birdCount = new BirdCount(birdsPerDay);
            Console.WriteLine("Total birds for the first 3 days: " + birdCount.CountForFirstDays(4));
            Console.WriteLine();

            Console.WriteLine("Act 6 Calculate the number of busy days");
            birdsPerDay = [2, 5, 0, 7, 4, 1];
            birdCount = new BirdCount(birdsPerDay);
            Console.WriteLine("Busy days: " + birdCount.BusyDays());
            Console.WriteLine();

        }
    }
}