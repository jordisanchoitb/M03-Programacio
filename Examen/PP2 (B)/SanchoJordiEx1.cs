/* 
    Autor: Jordi Sancho
    Data: 15/11/2023
    1. Implementa en C# el següent disseny de solució en pseudocodi. Escriu els literals que falten:

    programa practica és
        const
            FIRSTMSG = “___________________________________”;
            SECONDMSG = “___________________________________”;
        ficonst
        var 
            num, digit : enter;
        fivar
        digit = 0;
        escriure(FIRSTMSG);
        llegir(num);

        si num > 0 llavors
            mentre num > 0 llavors
	         num = num/10;
	         digit = digit + 1;
            fimentre
        sino
	      digit = 1;
        fisi
        escriure(SECONDMSG);
        escriure(digit);
    fiprograma


 */

using System;

namespace SegonaProvaPractica
{
    class SanchoJordiCodeEx1
    {
        static void Main()
        {
            const string FIRSTMSG = "Introdueix un numero i et dic quants digits te: ";
            const string SECONDMSG = "El nombre introduit te un total de: ";

            int num, digit;

            digit = 0;
            Console.WriteLine(FIRSTMSG);
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                while (num > 0)
                {
                    num = num / 10;
                    digit++;
                }
            } else
            {
                digit++;
            }
            Console.Write(SECONDMSG);
            Console.WriteLine(digit);
        }
    }
}




