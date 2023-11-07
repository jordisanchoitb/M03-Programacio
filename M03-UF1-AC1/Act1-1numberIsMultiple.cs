using System;
using System.Runtime.InteropServices;

namespace numberIsMultiple
{
    public class numberIsMultiple
    {
        public static void Main()
        {
            const string msgNoMult = "No es multiple";
            const string msgMult = "Es multiple";
            int number1, number2;
            bool numberWhile = true;

            Console.WriteLine("Donem dos nombres naturals i et dire si el primer es multiple del segon:");
            while (numberWhile) 
            { 
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 > 0 && number2 > 0)
                {
                    string print = (number1 % number2) == 0 ? msgMult : msgNoMult;
                    Console.WriteLine(print);
                    numberWhile = false;
                }
                else
                {
                    Console.WriteLine("Un dels dos números que has introduït no és un nombre natural, torna a introduir els números:");
                }
            }
            

        }
    }
}
