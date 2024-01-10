using System;
using System.Runtime.InteropServices;

namespace oddAndEvenNumbers
{
    public class oddAndEvenNumbers
    {
        public static void Main()
        {
            
            int number, evenNumber=0, oddNumber=0;
            
            Console.WriteLine("Donem 20 numeros enters i et dic quants son parells i quants son senars: ");
            for (int i = 0; i < 20; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if ((number % 2) == 0)
                {
                    evenNumber++;
                } else
                {
                    oddNumber++;
                }
            }
            Console.WriteLine("Hi han " + evenNumber + " numeros parells i " + oddNumber + " numeros impars.");

        }
    }
}