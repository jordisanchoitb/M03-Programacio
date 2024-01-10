/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 13/12/2023
 * 16. Implementa un programa que demani a l’usuari quants valors vol 
 * introduir, de manera que el programa generi una llista a partir de 
 * valors introduïts per teclat i retorni el producte de tots els 
 * elements d’aquesta. Els valors que l’usuari pot introduir són entre (15, 100) 
 * i l’usuari disposa de 5 intents en total. 
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MsgProgram = "Quants valors vols introduir: ";
            const string MsgProduct = "El producte dels valors introduits és: {0}";
            const string MsgInputValues = "Introdueix valors entre 15 i 100 (sol et pots equivocar 5 cops): ";
            int inputwhatvalues, count=0, inputtrys=1; 
            bool isvalid = false;

            Console.WriteLine(MsgProgram);
            inputwhatvalues = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[inputwhatvalues];

            Console.WriteLine(MsgInputValues);
            while (count < numbers.Length && inputtrys != 5)
            {
                int inputvalues;
                do
                {   
                    if (isvalid)
                    {
                        inputtrys++;
                    }
                    inputvalues = Convert.ToInt32(Console.ReadLine());
                    isvalid = true;
                } while (!(inputvalues > 15 && inputvalues < 100) && inputtrys != 5);
                if (inputtrys != 5)
                {
                    numbers[count] = inputvalues;
                }
                isvalid = false;
                count++;
            }

            Console.WriteLine(MsgProduct, Product(numbers));
        }

        public static int Product(int[] numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
    }
}