/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 3.  Implementa un programa que imprimeixi tots els nombres enters divisibles per 3 que hi ha entre num1 i num2 (inclosos), ambdós nombres enters introduïts per teclat.
 *
 */

using System;

namespace jumpnumbers2
{
    public class jumpnumbers2
    {
        public static void Main()
        {
            int firstnumber, secondnumber;
            const string MsgExplainProgram = "Introdueix 2 nobres enters i et retorno tots els numeros divisibles per 3 que hi hagin dins del rang proposat";
            const string Msgfirstnumber= "Introdueix el primer nombre: ";
            const string Msgsecondnumber = "Introdueix el segon nombre: ";

            Console.WriteLine(MsgExplainProgram);
            Console.WriteLine(Msgfirstnumber);
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Msgsecondnumber);
            secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = firstnumber; i <= secondnumber; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }
    }
}
