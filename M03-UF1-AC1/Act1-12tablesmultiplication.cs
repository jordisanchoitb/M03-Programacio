using System;

namespace tablesmultiplication
{
    public class tablesmultiplication
    {
        public static void Main()
        {
            int number;

            Console.WriteLine("Donem un numero i et retorno la taula de multplicar d'aquest: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + number + " = " + i*number);
            }

        }
    }
}