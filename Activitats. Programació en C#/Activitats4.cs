using System;

namespace LeapYear
{
    public class LeapYear
    {
        public static void Main()
        {
            // impar odd i par even
            const string MSGLeapYear = "Es un any de traspas";
            const string MSGNotLeapYear = "No es un any de traspas";

            int year;
            Console.WriteLine("Donem un any i et retorno si es un any de traspas o no: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year%4 == 0) 
            {
                Console.WriteLine(MSGLeapYear);
            } else
            {
                Console.WriteLine(MSGNotLeapYear);
            }
        }
    }
}
