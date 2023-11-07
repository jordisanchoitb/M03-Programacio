/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 20.  Especifica un algorisme que demani a l’usuari que introdueixi els números d’una matriu de 7 files 
 * per 3 columnes (compresos entre 1 i 9 inclosos) per teclat. Una vegada la matriu estigui omplerta, cal que el vostre 
 * programa mostri la matriu trasposta (només els valors, sense els claudàtors).
 *
 */

using System;

namespace Exercici20
{
    public class Exercici20
    {
        public static void Main()
        {
            const string MSGStartProgram = "Introdueixi els números d’una matriu de 7 files per 3 columnes (compresos entre 1 i 9 inclosos): ";
            const string MSGErrorInput = "Error, introdueix un numero d'entre 1 i el 9 inclosos: ";
            const int rows = 7, cols = 3;
            int numuser;
            bool errorinput = false;

            int[,] matrixnumber = new int[rows,cols];
            

            Console.WriteLine(MSGStartProgram);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
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
                    } while (!(numuser >= 1 && numuser <= 9));
                    matrixnumber[i,j] = numuser;
                }
            }
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(matrixnumber[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
