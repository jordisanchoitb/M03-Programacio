using System;

namespace evenNumbers
{
    public class evenNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Et mostrare els numeros parell d'entre 0 i el 100 inclosos tambe:");
            for (int i = 0; i <= 100; i++)
            {
                if ((i%2) == 0)
                {
                    Console.Write(i + ",");
                }
            }
        }
    }
}