using System;

namespace numrangediv7mult5
{
    public class numrangediv7mult5
    {
        public static void Main()
        {
            bool Comma= false;
            Console.WriteLine("Del rang de nombres enters d'entre 2000 i 3000 amb ells inclosos et mostrare per pantalla els que siguin divisibles entre 7 pero no siguin multiples de 5");
            
            for (int i = 2000; i <= 3000; i++)
            {
                if (i%7 == 0 && i%5 != 0)
                {
                    if (Comma)
                    {
                        Console.Write(",");
                    }
                    Console.Write(i);
                    Comma = true;
                 
                }
                
            }
        }
    }
}
