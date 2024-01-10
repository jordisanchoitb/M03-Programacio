using System;

namespace calcgrades
{
    public class calcgrades
    {
        public static void Main()
        {
            double usernumber;

            Console.WriteLine("Introdueix una nota i et retorno quina nota te, (Exelent,Notable,...)");
            Console.WriteLine("");
            Console.WriteLine("Introdueix la nota: ");

            usernumber = Convert.ToDouble(Console.ReadLine());

            if (usernumber >= 9)
            {
                Console.WriteLine("Exelent");
            } else if (usernumber >= 7)
            {
                Console.WriteLine("Notable");
            } else if (usernumber >= 6)
            {
                Console.WriteLine("Bé");
            } else if (usernumber >= 5)
            {
                Console.WriteLine("Suficient");
            } else if (usernumber >= 0 && usernumber <= 4.9)
            {
                Console.WriteLine("Suspès");
            } else { Console.WriteLine("Nota invàlida"); }
        }
    }
}
