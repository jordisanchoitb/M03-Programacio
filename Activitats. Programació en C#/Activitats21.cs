/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 21.  Implementa un programa en el que s’introdueixin 20 notes per terminal (valors entre el 0 i el 10 inclosos).
 * Un cop emmagatzemats, cal demanar a l’usuari quin valor vol cercar i el programa retornarà si aquest valor es troba 
 * entre els introduïts o no.
 *
 */

using System;

namespace Exercici21
{
    public class Exercici21
    {
        public static void Main()
        {
            const string MSGStartProgram = "Introdueixi 20 notes per terminal (valors entre el 0 i el 10 inclosos): ";
            const string MSGErrorInput = "Error, introdueix un numero d'entre 0 i el 10 inclosos: ";
            const string MSGSearchNumber = "Quin numero vols buscar si esta o no esta: ";
            const string MSGSearchNumberOK = "El valor esta dins: ";
            const string MSGSearchNumberNotOK = "No hi ha cap valor dins: ";
            const int lenghtarray = 20;
            int numuser, searchnumber, countnumber=0;
            bool errorinput = false, found = false;

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
            Console.WriteLine(MSGSearchNumber);
            searchnumber = Convert.ToInt32(Console.ReadLine());
            while (countnumber < arraynotes.Length && (!found))
            {
                if (arraynotes[countnumber] == searchnumber)
                {
                    found = true;
                }
            }
            Console.WriteLine(found ? MSGSearchNumberOK : MSGSearchNumberNotOK);
        }
    }
}
