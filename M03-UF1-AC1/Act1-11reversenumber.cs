using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace reversenumber
{
    public class reversenumber
    {
        public static void Main()
        {
            int num1, num2, extra;

            Console.WriteLine("Donem 2 numeros i intercambio l'ordre: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            extra = num1;
            num1 = num2;
            num2 = extra;

            Console.WriteLine("El camvi d'ordre es: " + num1 + " " + num2);

        }
    }
}