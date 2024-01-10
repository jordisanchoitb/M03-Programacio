/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 18.  Implementa un programa que reculli els valors dels següents atributs per a 4 personatges:
 *
 */

using System;

namespace Exercici18
{
    public class Exercici18
    {
        public static void Main()
        {
            const string MSGStartProgram = "Donem els atributs dels personatges: ";
            const string MSGSetHp = "Vida [1-1000]: ";
            const string MSGSetPower = "Poder [100-500]: ";
            const string MSGSetStregh = "Força [20-50]: ";

            const string MSGErrorSet = "Error, introdueix els valors dins del rang especificat, torna a intentarlo: ";
            bool errorsetnumber = false;
            
            const int rows=4, cols=3;
            int usernumber=0;
            int[,] matrixcharacter = new int[rows,cols];

            Console.WriteLine(MSGStartProgram);
            for (int i = 0; i < matrixcharacter.GetLength(0); i++)
            {
                for (int j = 0; j < matrixcharacter.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        errorsetnumber = false;
                        Console.Write(MSGSetHp);
                        do
                        {
                            if (errorsetnumber)
                            {
                                Console.WriteLine(MSGErrorSet);
                                Console.Write(MSGSetHp);
                            }
                            usernumber = Convert.ToInt32(Console.ReadLine());
                            errorsetnumber = true;
                        } while (!(usernumber >= 1 && usernumber <= 1000));
                    } else if (j == 1)
                    {
                        errorsetnumber = false;
                        Console.Write(MSGSetPower);
                        do
                        {
                            if (errorsetnumber)
                            {
                                Console.WriteLine(MSGErrorSet);
                                Console.Write(MSGSetPower);
                            }
                            errorsetnumber = true;
                            usernumber = Convert.ToInt32(Console.ReadLine());
                        } while (!(usernumber >= 100 && usernumber <= 500));
                    } else if (j == 2) 
                    {
                        errorsetnumber = false;
                        Console.Write(MSGSetStregh);
                        do
                        {
                            if (errorsetnumber)
                            {
                                Console.WriteLine(MSGErrorSet);
                                Console.Write(MSGSetStregh);
                            }
                            usernumber = Convert.ToInt32(Console.ReadLine());
                            errorsetnumber = true;
                        } while (!(usernumber >= 20 && usernumber <= 50));
                    }
                    matrixcharacter[i, j] = usernumber;
                    Console.WriteLine("");
                }
            }

            for (int i = 0; i < matrixcharacter.GetLength(0); i++)
            {
                for (int j = 0; j < matrixcharacter.GetLength(1); j++)
                {
                    Console.Write(matrixcharacter[i, j] + " ");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
