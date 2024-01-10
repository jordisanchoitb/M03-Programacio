/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 19.  Implementa un programa que reculli les següents dades per 10 persones:
 *
 */

using System;

namespace Exercici19
{
    public class Exercici19
    {
        public static void Main()
        {
            const string MSGStartProgram = "Donem les dades de 10 persones: ";
            const string MSGAge = "Edad (enter): ";
            const string MSGGender = "Sexe (H/D, caràcter) ";
            const string MSGSalary = "Força (decimal): ";
            const string MSGScholarShipHolder = "Becari (true/false, booleà): ";
            const string MSGCountPerson1 = "Dades ";
            const string MSGCountPerson2 = " persona: ";
            int numperson = 1 ;

            int[] arrayage = new int[10];
            char[] arraygender = new char[10];
            double[] arraysalary = new double[10];
            bool[] arrayscholarshipHolder = new bool[10];

            Console.WriteLine(MSGStartProgram);
            Console.WriteLine(MSGAge);
            Console.WriteLine(MSGGender);
            Console.WriteLine(MSGSalary);
            Console.WriteLine(MSGScholarShipHolder);
            for (int i = 0; i < arrayage.Length; i++)
            {
                Console.WriteLine(MSGCountPerson1+numperson+MSGCountPerson2);
                
                arrayage[i] = Convert.ToInt32(Console.ReadLine());
                arraygender[i] = Convert.ToChar(Console.ReadLine());
                arraysalary[i] = Convert.ToDouble(Console.ReadLine());
                arrayscholarshipHolder[i] = Convert.ToBoolean(Console.ReadLine());
                numperson++;
            }
            numperson = 1 ;
            for (int i = 0;i < arrayage.Length;i++)
            {
                Console.Write(numperson + MSGCountPerson2);
                for (int j = 0; j< arrayage.Length;j++) 
                {
                    Console.Write(arrayage[i]+" "+arraygender[i]+" "+ arraysalary[i]+" "+arrayscholarshipHolder[i]);
                    numperson++;
                }
                Console.WriteLine();
            }

            
            
        }
    }
}
