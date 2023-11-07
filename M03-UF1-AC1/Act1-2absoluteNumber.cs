using System;
using System.Runtime.InteropServices;

namespace absoluteNumber
{
    public class absoluteNumber
    {
        public static void Main()
        {
            int number;
            
            Console.WriteLine("Donem un numero enter i et retornare el nombre absolut:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                number *= -1;
            }
            Console.WriteLine("El nombre absolut es: " + number);

        }
    }
}
