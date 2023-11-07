using System;
namespace numbersum 
{
    class numbersum 
    {
        static void Main() 
        {
            int number, resultatmod10=0, numsum=0, resultatdiv10=0;
            Console.WriteLine("Un numero enter positiu i et faig la suma de les sevas xifres: ");
            Console.WriteLine("Introdueix el numero: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            while (number > 0) 
            {
                resultatmod10 = number % 10;    
                number /= 10;
                numsum += resultatmod10;
            }
            Console.WriteLine("El resoltat es: " + numsum);
        }
    }
}