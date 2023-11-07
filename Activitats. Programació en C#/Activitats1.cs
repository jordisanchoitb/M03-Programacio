using System;

namespace numberrange
{
    public class numberrange
    {
        public static void Main()
        {
            int min, max, number;
            
            Console.WriteLine("Donem 1 nombre minim i 1 nombre maxim");
            Console.WriteLine("Nombre minim: ");
            min = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Nombre maxim: ");
            max = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Donem un nombre: ");
            number = Convert.ToInt32 (Console.ReadLine());

            if (min < number && number < max)
            {
                Console.WriteLine("El nombre esta dins del rang posat");
            } else
            {
                Console.WriteLine("EL nombre no esta dins del rang posat");
            }

        }
    }
}
