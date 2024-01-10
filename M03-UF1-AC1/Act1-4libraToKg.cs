using System;

namespace libraToKg
{
    public class libraToKg
    {
        public static void Main()
        {
            int libras, anothercalc;
            double kg;
            bool whilecalc;
            
            whilecalc = true;

            while (whilecalc)
            {
                Console.WriteLine("Donem les lliures que pesa el producte i et dic quants Kg son: ");
                libras = Convert.ToInt32(Console.ReadLine());
                kg = libras / 2.2046;
                Console.WriteLine("Son " + kg + " Kg.");
                Console.WriteLine("Si vols finalitzar el programa introdueix un (0)");
                anothercalc = Convert.ToInt32(Console.ReadLine());
                whilecalc = anothercalc != 0;
            }
        }
    }
}