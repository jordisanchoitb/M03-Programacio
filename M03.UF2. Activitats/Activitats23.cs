/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * Exercici 23. Implementa un programa que retorni l'àrea per consola de les següents figures geomètriques:
a. quadrat
b. rectangle
c. cercle
d. pentàgon
El programa haurà de demanar per teclat els valors necessaris.
 */

using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "Que vols calcular? \nA) Quadrat \nB) Rectangle \nC) Cercle \nD) Pentagon \nE) Sortir";
            const string MsgError = "Error, opció invàlida";

            Console.WriteLine(MsgWelcome);
            string option = Console.ReadLine();
            switch (option)
            {
                case "A":
                    Console.WriteLine("Introdueix el costat del quadrat");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("L'àrea del quadrat és: " + Square(side));
                    break;
                case "B":
                    Console.WriteLine("Introdueix la base del rectangle");
                    double baseRectangle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introdueix l'altura del rectangle");
                    double heightRectangle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("L'àrea del rectangle és: " + Rectangle(baseRectangle, heightRectangle));
                    break;
                case "C":
                    Console.WriteLine("Introdueix el radi del cercle");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("L'àrea del cercle és: " + Circle(radius));
                    break;
                case "D":
                    Console.WriteLine("Introdueix el costat del pentàgon");
                    double sidePentagon = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introdueix l'apotema del pentàgon");
                    double apothem = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("L'àrea del pentàgon és: " + Pentagon(sidePentagon, apothem));
                    break;
                case "E":
                    Console.WriteLine("Adeu!");
                    break;
                default:
                    Console.WriteLine(MsgError);
                    break;
            }
        }
        public static double Square(double side)
        {
            return Math.Pow(side, 2);
        }

        public static double Rectangle(double baseRectangle, double heightRectangle)
        {
            return baseRectangle * heightRectangle;
        }

        public static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double Pentagon(double sidePentagon, double apothem)
        {
            return (sidePentagon * 5 * apothem) / 2;
        }
    }
}