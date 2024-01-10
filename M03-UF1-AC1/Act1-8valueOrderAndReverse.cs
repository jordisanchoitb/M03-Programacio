using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace valueOrderAndReverse
{
    public class valueOrderAndReverse
    {
        public static void Main()
        {
            //Maxim de numeros totals es 18
            int numbertotal = 18;
            long numbers = 0, reversenumbers = 0, up = 1, down = 1, number;
            bool whileverif;

            Console.WriteLine("Donem " + numbertotal + " numeros enters entre el 1 i el 9 inclosos ells, i et retorno ordre de valors introduit i el ordre al reves");
            for (int j = 0; j < numbertotal; j++) 
            {
                down *= 10;
            }

            for (int i = 0; i < numbertotal; i++)
            {
                do
                {
                    number = Convert.ToInt64(Console.ReadLine());
                    if (number > 0 && number <= 9)
                    {
                        reversenumbers += number * up;
                        up *= 10;

                        down /= 10;
                        numbers += down * number;

                        whileverif = false;
                    }
                    else
                    {
                        Console.WriteLine("No has introduit un numero d'entre el 1 i el 9 inclosos ells");
                        whileverif = true;
                    }
                    /*Console.WriteLine("Valor reversenumber bucle for: " + reversenumbers);
                    Console.WriteLine("Valor numbers bucle for: " + numbers);*/
                } while (whileverif);
            }
            Console.WriteLine("Ordre de valors introduit: " + numbers);
            Console.WriteLine("Ordre de valors introduit al reves: " + reversenumbers);
        }
    }
}