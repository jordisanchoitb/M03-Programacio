using System;

namespace createrhombu
{
    public class createrhombu
    {
        public static void Main()
        {
            int number, hastag=1, space, rows;

            Console.Write("Introduiex l'altura de la piramide i et retorno la piramide: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            space=rows= number;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < hastag; j++) 
                { 
                    Console.Write("#");
                    Console.Write(" ");
                }
                Console.WriteLine("");
                hastag++;
                space++;
            }
        }
    }
}