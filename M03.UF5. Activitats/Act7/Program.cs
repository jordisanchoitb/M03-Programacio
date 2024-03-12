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
            List<Employee> employees = new List<Employee>()
            {
                new Employee("Jordi", "Sancho", "0001", new DateOnly(1999, 1, 1), new DateOnly(2020, 1, 1)),
                new Employee("Maria", "Sancho", "0002", new DateOnly(1999, 1, 1), new DateOnly(2022, 2, 3)),
                new Employee("Pepe", "Sancho", "0003", new DateOnly(1999, 1, 1), new DateOnly(2023, 3, 4)),
                new Employee("Adria", "Sancho", "0004", new DateOnly(1999, 1, 1), new DateOnly(2024, 4, 5)),
                new Employee("David", "Sancho", "0005", new DateOnly(1999, 1, 1), new DateOnly(2019, 5, 6)),
            };
            List<SalesEmployee> sales = new List<SalesEmployee>()
            {
                new SalesEmployee("Qihang", "Sancho", "0006", new DateOnly(1999, 1, 1), new DateOnly(2020, 1, 1), 0.1f),
                new SalesEmployee("Marcos", "Sancho", "0007", new DateOnly(1999, 1, 1), new DateOnly(2012, 2, 3), 0.2f),
                new SalesEmployee("Milko", "Sancho", "0008", new DateOnly(1999, 1, 1), new DateOnly(2019, 3, 4), 0.3f),
                new SalesEmployee("Adrian", "Sancho", "0009", new DateOnly(1999, 1, 1), new DateOnly(2024, 1, 8), 0.4f),
                new SalesEmployee("Laura", "Sancho", "0010", new DateOnly(1999, 1, 1), new DateOnly(2013, 5, 6), 0.5f),
            };

            employees.Sort();
            sales.Sort();

            Console.WriteLine($"Employees list");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine($"SalesEmployees List");
            foreach (var sale in sales)
            {
                Console.WriteLine(sale);
            }


        }
    }
}
