/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 9/1/2024
 * Exercici Pomer. Implementa la canço del pomer de manera recursiva.
 * lletra:
 * Cinc pometes té el pomer,
 * de cinc una, de cinc una,
 * cinc pometes té el pomer,
 * de cinc una en caigué.
 * 
 * Si mireu el vent d'on ve,
 * veureu el pomer com dansa,
 * si mireu el vent d'on ve,
 * veure com dansa el pomer.
 * 
 */

using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "Introdueix les pomes del pomer: ";
            const string MsgError = "Error, no has introduit un nombre natural, torna a intentarlo";
            int num;
            bool error = false;
            Console.WriteLine(MsgWelcome);
            do
            {
                if (error)
                {
                    Console.WriteLine(MsgError);
                }
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);
            Pomer(num);
        }

        public static void Pomer(int pomes)
        {
            if (pomes == 0)
            {
                return;
            } else if (pomes == 1)
            {
                Console.WriteLine($"{pomes} pometa té el pomer,");
                Console.WriteLine($"de {pomes} una, de {pomes} una,");
                Console.WriteLine($"{pomes} pometa té el pomer,");
                Console.WriteLine($"de {pomes} una en caigué,");

                Console.WriteLine($"Si mireu el vent d'on ve,");
                Console.WriteLine($"veureu el pomer com dansa,");
                Console.WriteLine($"si mireu el vent d'on ve,");
                Console.WriteLine($"veure com dansa el pomer.");
            }
            else
            {
                Console.WriteLine($"{pomes} pometes té el pomer,");
                Console.WriteLine($"de {pomes} una, de {pomes} una,");
                Console.WriteLine($"{pomes} pometes té el pomer,");
                Console.WriteLine($"de {pomes} una en caigué,");

                Console.WriteLine($"Si mireu el vent d'on ve,");
                Console.WriteLine($"veureu el pomer com dansa,");
                Console.WriteLine($"si mireu el vent d'on ve,");
                Console.WriteLine($"veure com dansa el pomer.");
                Console.WriteLine();

                Pomer(pomes - 1);
            }
        }

        
    }
}