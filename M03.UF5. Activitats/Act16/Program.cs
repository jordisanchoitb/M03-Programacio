/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 
 * 
 * 
*/
using System.Text;
using System.Text.RegularExpressions;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            Employee e = new Employee("Jordi", "Sancho", "12345678A");
            System.Console.WriteLine(e.ToString());
            Administrators a = new Administrators("Jordi", "Sancho", "12345678A", "IT", "Admin");
            System.Console.WriteLine(a.ToString());

        }        
    }
}
