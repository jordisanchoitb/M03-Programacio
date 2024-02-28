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
            MaquinaExpendedora maquina = new MaquinaExpendedora(1.5, 10);
            
            Console.WriteLine(maquina.TreureTiquet());



        }
    }
}