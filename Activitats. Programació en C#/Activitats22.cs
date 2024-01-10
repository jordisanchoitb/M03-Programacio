/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 22. Modifica el programa anterior de manera que mostri les notes introduïdes 
 * ordenades de manera ascendent i descendent (per separat).
 *
 */

using System;

namespace Exercici22
{
    public class Exercici22
    {
        public static void Main()
        {
            const string MSGStartProgram = "Introdueixi 20 notes per terminal (valors entre el 0 i el 10 inclosos): ";
            const string MSGErrorInput = "Error, introdueix un numero d'entre 0 i el 10 inclosos: ";
            const string MSGAscendant = "Incremental (De 0 a 10): ";
            const string MSGDescendent = "Descendent (De 10 a 0): ";

            const int lenghtarray = 20;
            int numuser;
            bool errorinput = false;

            int[] arraynotes = new int[lenghtarray];
            

            Console.WriteLine(MSGStartProgram);
            for (int i = 0; i < arraynotes.Length; i++)
            {
                errorinput = false;
                do
                {
                    if (errorinput) 
                    { 
                        Console.WriteLine(MSGErrorInput);
                    }
                    numuser = Convert.ToInt32(Console.ReadLine());
                    errorinput = true;
                } while (!(numuser >= 0 && numuser <= 10));
            }
            
            for (int i = 0;i < arraynotes.Length;i++)
            {
                for (int j = i + 1;  j < arraynotes.Length;j++)
                {
                    if (arraynotes[i] > arraynotes[j])
                    {
                        int aux = arraynotes[i];
                        arraynotes[i] = arraynotes[j];
                        arraynotes[j] = aux;
                    }
                }
            }
            Console.WriteLine(MSGAscendant);
            for (int i = 0; i < arraynotes.Length ; i++)
            {
                Console.Write(arraynotes[i]);
            }
            Console.WriteLine();
            Console.WriteLine(MSGDescendent);
            for (int i = arraynotes.Length; i > 0 ; i--)
            {
                Console.Write(arraynotes[i]);
            }
        }
    }
}
