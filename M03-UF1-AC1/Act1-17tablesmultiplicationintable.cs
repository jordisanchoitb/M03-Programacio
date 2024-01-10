using System;

namespace tablesmultiplicationintable
{
    public class tablesmultiplicationintable
    {
        public static void Main()
        {
            int number=1, multiplicationnumber;

            Console.WriteLine("Aqui tens les taules de multiplicar en forma de taula. ");

            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i);
                for (int j = 2; j < 10; j++)
                {
                    Console.Write(" " + i*j);
                }
                Console.WriteLine("");
            }

        }
    }
}