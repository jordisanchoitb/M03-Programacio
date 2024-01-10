/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 8/11/2023
 * Exercici 1. Implementa un programa que demani a l’usuari quants valors vol introduir i
 * el programa generi una llista, a partir de valors introduïts per teclat, retornant 
 * la suma de tots els elements d’aquesta.
 *
 */
using System;

namespace Exercici1
{
    public class Exercici1
    {
        public static void Main()
        {
            const string MSGProgram = "Donem una serie de numeros i et retorno la suma de tots ells."; 
            const string MSGCase = "Quant valors vols introduir?";
            const string MSGSumNumbers = "La suma del nombres introduit es: ";
            int userinputmaxnumbers, usernumber, sumnumbers=0;

            Console.WriteLine(MSGProgram);
            Console.WriteLine(MSGCase);
            userinputmaxnumbers = Convert.ToInt32(Console.ReadLine());
            int[] arrayUserNumbers = new int[userinputmaxnumbers];
            for (int i = 0; i < userinputmaxnumbers; i++)
            {
                usernumber = Convert.ToInt32(Console.ReadLine());
                arrayUserNumbers[i] = usernumber;
            }
            for (int i = 0;i < arrayUserNumbers.Length; i++) 
            { 
                sumnumbers += arrayUserNumbers[i]; 
            }
            Console.WriteLine($"{MSGSumNumbers}{sumnumbers}");

        }
    }
}

