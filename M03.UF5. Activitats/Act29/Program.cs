﻿/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 

 */
using System;
using System.Linq;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1,12 , -7, 8,-43,-23,54,65,-76,12,43 };
            int searchNumber = 12;
            var evenNumbers = from number in numbers
                              where number == searchNumber
                              select number;
            int count=0;
            foreach (var item in evenNumbers)
            {
                count++;
            }
            Console.WriteLine($"El numero {searchNumber} es repateix {count} vegades");
        }
    }
}
