/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Rept 2.  La torre ha de ser en forma de piràmide quadrada.Això significa que el primer pis tindrà un Ferrero, 
 * el segon 4, el tercer 9, el quart 16, i així successivament (cada pis és un quadrat amb un més a cada cantó).
 *
 */
using System;

namespace Rept2
{
    public class Rept2
    {
        public static void Main()
        {
            const string MSGProgram = "Donem el numero de pisos i et retorno quants bombons necesites."; 
            const string MSGCase = "Quants casos vols provar?";
            const string MSGGetNmbers = "Introdueix el numero de pisos: ";
            const string MSGNumberBombon = "El numero de bombons necesaris es: ";

            int userinputcase, usernumber, numberbombon;

            Console.WriteLine(MSGProgram);
            Console.WriteLine(MSGCase);
            userinputcase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userinputcase; i++)
            {
                numberbombon = 0;
                Console.WriteLine(MSGGetNmbers);
                usernumber = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j <= usernumber;j++)
                {
                    numberbombon += j * j;
                }
                Console.WriteLine($"{MSGNumberBombon}{numberbombon}");
            }

        }
    }
}

