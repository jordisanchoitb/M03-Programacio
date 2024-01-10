/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 10. Dissenya un programa que generi una llista de 10 valors aleatoris entre el 0 i el 200, 
 * demani un valor per teclat i informi per pantalla si aquest valor indicat es troba a la llista.
  
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            int usernumber;
            Console.WriteLine("Donem un numero");
            usernumber = Convert.ToInt32(Console.ReadLine());
            ValorIsInArray(usernumber);


        }
        public static void ValorIsInArray(int usernumber)
        {
            int[] arraynumbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < arraynumbers.Length; i++)
            {
                arraynumbers[i] = random.Next(201);
            }

            int j = 0;
            bool found = false;
            while (j < arraynumbers.Length && !(found))
            {
                if (arraynumbers[j] == usernumber)
                {
                    found = true;
                }
                j++;
            }

            Console.WriteLine(found ? "El nombre introduit per el usuari esta dins l'array" : "El nombre introduit per el usuari no esta dins l'array");

        }
    }
}