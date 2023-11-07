/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 23. Implementa un programa en el que s’introdueixin 20 notes per terminal 
 * (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a l’usuari si vol 
 * mostrar els valors ordenats de manera ascendent o descendent i mostrar-ho per pantalla.
 *
 */

using System;

namespace Exercici23
{
    public class Exercici23
    {
        public static void Main()
        {
            const string MSGStartProgram = "Introdueixi 20 notes per terminal (valors entre el 0 i el 10 inclosos): ";
            const string MSGAscendatOrDescendent = "Amb que vols que et mostri els valor de manera Ascendent[a] o Descendent[d]:";
            const string MSGErrorInput = "Error, introdueix un numero d'entre 0 i el 10 inclosos: ";
            const string MSGAscendant = "Incremental (De 0 a 10): ";
            const string MSGDescendent = "Descendent (De 10 a 0): ";

            const int lenghtarray = 20;
            int numuser;
            char sortuser;
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
            Console.WriteLine(MSGAscendatOrDescendent);
            sortuser = Convert.ToChar(Console.ReadLine());

            switch (sortuser)
            {
                case 'a':
                case 'A':
                    Console.WriteLine(MSGAscendant);
                    for (int i = 0; i < arraynotes.Length ; i++)
                    {
                        Console.Write(arraynotes[i]);
                    }
                    break;
                case 'd':
                case 'D':
                    Console.WriteLine(MSGDescendent);
                    for (int i = arraynotes.Length; i > 0; i--)
                    {
                        Console.Write(arraynotes[i]);
                    }
                    break;
            }
        }
    }
}
