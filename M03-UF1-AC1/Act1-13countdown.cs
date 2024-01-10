using System;

namespace countdown
{
    public class countdown
    {
        public static void Main()
        {
            int number;

            Console.WriteLine("Donem un numero i et retorno el compte enrere: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("La compte erere es de: ");
            while (number > 0)
            {
                Console.Write(number);
                number--;
            }

        }
    }
}