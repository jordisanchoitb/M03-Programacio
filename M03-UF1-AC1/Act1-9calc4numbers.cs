using System;

namespace calc4numbers
{
    public class calc4numbers
    {
        public static void Main()
        {
            int number1, number2, number3, number4;
            bool whileverif;
           

            Console.WriteLine("Donem 4 numeros enters i et torno  el valor de sumar el primer amb el segon, multiplicat per el mòdul del tercer amb el quart: ");
            do
            {
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                number3 = Convert.ToInt32(Console.ReadLine());
                number4 = Convert.ToInt32(Console.ReadLine());

                if (number1 >= 0 && number2 >= 0 && number3 >= 0 && number4 >= 0)
                {
                    Console.WriteLine("El resoltat es: " + ((number1+number2)*(number3%number4)));
                    whileverif = false;
                }
                else
                {
                    Console.WriteLine("No has introduit un numero enter en algun dels 4 numeros torna a introduirlos: ");
                    whileverif = true;
                }
            } while (whileverif);   
        }
    }
}