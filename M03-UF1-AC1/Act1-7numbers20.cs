using System;

namespace numbers20
{
    public class numbers20
    {
        public static void Main()
        {
            int number, result=0;
            
            Console.WriteLine("Donem 20 numeros i els emmagatzemo segons les seguents indicacions: ");
            Console.WriteLine("Si el nombre és divisible per 5, +3 al nombre rebut");
            Console.WriteLine("Si el nombre és divisible per 3, -2 al nombre rebut");
            Console.WriteLine("En cas contrari, emmagatzemar el valor rebut");
            Console.WriteLine("");
            Console.WriteLine("Introdueix els numeros: ");
            for (int i = 0; i < 20; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 5 == 0)
                {
                    number += 3;
                    result += number ;

                } else if (number % 3 == 0) 
                {
                    number -= 2;
                    result += number;

                } else
                {
                    result += number;
                }
            }
            Console.WriteLine("Els numeros guardat son: " + result);
        }
    }
}