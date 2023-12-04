/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 28/11/2023
 * 12. Demanar per teclat el nombre de litres consumits aquest mes i calcular la factura d’aigua, tenint en compte les següents dades:
La quota fixa és de 6€.
Els primers 50 litres d’aigua són de franc.
Entre 50 i 200 litres, el litre costa 0,1€
A partir de 200 el litre costa 0,3€.

 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {

            int usernumber;
            Console.WriteLine("Donem el numero de litres consumits aquest mes");
            usernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La factura d'aquest mes sera de {FactureWater(usernumber)}");

        }
        public static double FactureWater(int number)
        {
            double fixedprice = 6;
            if (number <= 50)
            {
                return fixedprice;
            }
            else if (number > 50 && number < 200)
            {
                for (int i = 0; i < number - 50; i++)
                {
                    fixedprice += 0.1;
                }
                return Math.Round(fixedprice, 1);
            }
            else
            {
                for (int i = 0; i < number - 50; i++)
                {
                    fixedprice += 0.1;
                }

                for (int i = 0; i < number - 200; i++)
                {
                    fixedprice += 0.3;
                }
                return Math.Round(fixedprice,1);
            }
        }
    }
}