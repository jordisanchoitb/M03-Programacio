/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 2.  Implementa un programa on l’usuari introdueixi dos valors enters: el valor final i el salt. El programa haurà d’escriure tots els números des de l'1 fins al valor final (inclòs), amb una distància del salt indicat.
 *
 */

using System;

namespace jumpnumbers
{
    public class jumpnumbers
    {
        public static void Main()
        {
            int finalnumber, jumpnumber;
            const string MsgExplainProgram = "Introdueix 2 nobres enters el primer el valor final i el segon el de salt i et retorno tots els numeros desde el 1 fins el valor final inclos";
            const string MsgFinalnumber = "Introdueix el nombre final: ";
            const string MsgJumpnumber = "Introdueix el nombre de salts";

            Console.WriteLine(MsgExplainProgram);
            Console.WriteLine(MsgFinalnumber);
            finalnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgJumpnumber);
            jumpnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= finalnumber; i += jumpnumber)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}
