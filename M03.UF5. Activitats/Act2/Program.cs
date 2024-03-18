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
            Propietari propietari = new Propietari("Jordi", "Sancho", "12345678A", 666666666);
            Pacient pacient = new Pacient("Bobby", "Golden Retriever", 5, true);
            Visita visita = new Visita(propietari, pacient, "Urgent");
            Visita visita2 = new Visita(propietari, pacient, new DateTime(2023, 4, 10), "Urgent");
            Visita visita3 = new Visita(propietari, pacient, new DateTime(2026, 2, 12), "No Urgent");
            Visita visita4 = new Visita(propietari, pacient, new DateTime(2022, 6, 25), "Parcial");
            Visita visita5 = new Visita(propietari, pacient, new DateTime(2021, 2, 15), "Urgent");
            List<Visita> visites = new List<Visita> { visita, visita2, visita3, visita4, visita5 };
            Console.WriteLine($"|   Data   | Propietaria | Pacient |   Motiu   |\n" +
                "|----------|-------------|---------|-----------|");
            foreach (Visita v in visites)
            {
                Console.WriteLine(v);
            }

        }
    }
}
