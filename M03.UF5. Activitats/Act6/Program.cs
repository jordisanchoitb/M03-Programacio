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
            Employee employee = new("Jordi", "Sancho", "jordisancho05@gmail.com", 84488556, new DateOnly(2005, 01, 07));
            Console.WriteLine($"El empleat {employee.Name} te {Employee.Age(employee.BirthDate)} anys");

        }
    }
}
