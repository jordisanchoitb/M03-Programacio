using System;
namespace numberpow 
{
    class numberpow 
    {
        static void Main() 
        {
            int number, pow, resultat=1;
            Console.WriteLine("Introdueix la base i l'exponent i t'impremeixo el resultat de la potencia");
            Console.WriteLine("Introdueix el numero: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix l'exponent: ");
            pow = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < pow; i++) 
            {
                resultat *= number;
            }
            
            Console.WriteLine("El resultat es: " + resultat);
        }
    }
}