/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * 31. El següent tipus de dades emmagatzema les quantitats
 * mitjanes de pluja per cada mes de l’any:
 * a) Mostri tot el contingut de l'array, mostrant les mitjanes de cada mes de manera descendent. Un exemple de sortida seria aquest:
 * b) Compti quants mesos han tingut pluges entre 5 i 18 litres de mitjana (inclosos),  torni a mostrar el llistat de valors, 
 * la mitjana i el recompte calculat. Una possible sortida del programa seria aquesta:
 * c) Demani per teclat un valor i cerqui aquest dins l’array. Si el troba, 
 * ho ha d’indicar (aturant-se en trobar-lo, no s’ha de recórrer tot l’array).
 * Si no l’ha trobat, informar que el valor no està dins l’array. Important! No
 * cal validar el valor introduït per teclat.
 */

using System;

namespace Exercici31
{
    public class Exercici31
    {
        public static void Main()
        {
            float[] arrayPluges = { 15.5f, 10f, 3.2f, 1.25f, 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f };
            string MSGUserSearch = "Donem un numero per teclat i et dic si esta hi ha hagut aquest valor: ";
            string MSGSearchOK = "El valor esta dins";
            string MSGSearchNotOK = "El valor no esta dins";
            string MSGMonth = "Mes ";
            double usernumber;
            bool found = false;
            float sumarray = 0;
            int countPuges = 0, arraycount;
            for (int i = 0; i < arrayPluges.Length; i++)
            {
                for (int j = i + 1;  j < arrayPluges.Length; j++)
                {
                    if (arrayPluges[i] < arrayPluges[j])
                    {
                        float aux = arrayPluges[i];
                        arrayPluges[i] = arrayPluges[j];
                        arrayPluges[j] = aux;
                    }
                }
            }

            for (int i = 0;i < arrayPluges.Length;i++)
            {
                Console.WriteLine($"{MSGMonth}{i}: {arrayPluges[i]}");
                sumarray += arrayPluges[i];
                if (arrayPluges[i] > 5 && arrayPluges[i] < 18)
                {
                    countPuges++;
                }

            }
            Console.WriteLine($"La mitjana és {sumarray / arrayPluges.Length}");
            Console.WriteLine($"Hi ha {countPuges} mesos amb mitjanes de plujes entre 5 i 18 litres");

            Console.WriteLine(MSGUserSearch);
            usernumber = Convert.ToDouble(Console.ReadLine());
            arraycount = 0;
            while (arraycount < arrayPluges.Length && !(found))
            {
                if (arrayPluges[arraycount] == usernumber)
                {
                    found = true;
                }
                arraycount++;
            }
            Console.WriteLine(found ? MSGSearchOK : MSGSearchNotOK);
        }
    }
}
