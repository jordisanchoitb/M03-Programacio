using System;

namespace createrhombu
{
    public class createrhombu
    {
        public static void Main()
        {
            int number, asterisc=1, space, rows;

            Console.Write("Introduiex que tan gran vols el rombe: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            space=rows= number - 1;

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < space; k++) 
                { 
                    Console.Write(" ");
                }
                for (int j = 0; j < asterisc; j++) 
                { 
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine("");
                asterisc++;
                space--;
            }

            for (int i = 0; i <= rows; i++)
            {
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterisc; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine("");
                asterisc--;
                space++;
            }
        }
    }
}