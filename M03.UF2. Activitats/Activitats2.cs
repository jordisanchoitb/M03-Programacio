/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 2. Crea un programa que demani per teclat un la base i 
 * l’exponent i retorni la potència
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSGBase = "Introdueix la base del numero";
            const string MSGPower = "Introdueix l'exponen del numero";
            int basenumber, powernumber;
            Console.WriteLine(MSGBase);
            basenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MSGPower);
            powernumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La potencia es: " + Power(basenumber,powernumber));
        }

        public static int Power(int basenum, int powernum)
        {
            int power=1;

            for (int i = 0; i < basenum; i++)
            {
                power *= powernum;
            }
	    if (powernum == 0) 
	    {
	    	return 1;
	    } else 
	    {
            	return power;
	    }
        }
    }
}