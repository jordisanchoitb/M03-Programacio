/* 
    Autor: Jordi Sancho
    Data: 23/10/2023
    7. Implementa en C# el següent disseny de solució en pseudocodi. Si hi ha alguna manera d’optimitzar-la, aplica-la directament en el teu programa, comentant-la:

 */

using System;

namespace PrimeraProvaPractica
{
    class SanchoJordiEx7
    {
        static void Main()
        {
            const int divider = 2, zero=0;
            const string MSGStartProgram = "Introdueix un nombre i et dic si es parell o no: ";
            const string uneven = "Es no parell";
            const string even = "Es parell";

            int number;
            

            Console.WriteLine(MSGStartProgram);
            number = Convert.ToInt32(Console.ReadLine());
            /* Com es una condicio de si o no he utilitzat un operador ternari */
            Console.WriteLine(number%divider != zero ? uneven : even);
        }
    }
}




