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
            Cercle c = new Cercle("Cercle", 5);
            Triangle t = new Triangle("Triangle", 5, 3);
            Quadrat q = new Quadrat("Quadrat", 5);

            Console.WriteLine("Area of {0} is {1}", c.GeometricName, c.Area());
            Console.WriteLine("Perimeter of {0} is {1}", c.GeometricName, c.Perimeter());

            Console.WriteLine("Area of {0} is {1}", t.GeometricName, t.Area());
            Console.WriteLine("Perimeter of {0} is {1}", t.GeometricName, t.Perimeter());

            Console.WriteLine("Area of {0} is {1}", q.GeometricName, q.Area());
            Console.WriteLine("Perimeter of {0} is {1}", q.GeometricName, q.Perimeter());


        }
    }
}