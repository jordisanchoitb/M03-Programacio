/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 

 */
using System;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            FullTimeWorker fullTimeWorker = new FullTimeWorker("Jordi", 10, 80);
            HourlyWorker hourlyWorker = new HourlyWorker("Jordi", 5, 40);
            
            Console.WriteLine(fullTimeWorker.computePay());
            Console.WriteLine(hourlyWorker.computePay());



        }
    }
}