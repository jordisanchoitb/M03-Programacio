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
            Propietari propietari = new Propietari("Jordi", "Sancho", "12345678A", 666666666);
            Pacient pacient = new Pacient("Bobby", "Pastor Alemany", 5, true);
            Visita visita1 = new Visita(propietari, pacient, "5/2/2024", "Urgencia");

            Console.WriteLine(visita1.ToString());


            

        }
    }
}