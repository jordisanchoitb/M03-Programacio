using System;

namespace Exercici13
{
    class Exercici13
    {
        static void Main()
        {
            const string MSGStartProgram = "Donem 20 numeros i et retorno els valors de les posicions senars: ";

            const int maxnumber = 20;

            int[] arraynumbers = new int[maxnumber];


            Console.WriteLine(MSGStartProgram);

            for (int i = 0; i < maxnumber; i++)
            {
                arraynumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");

            for (int i = 0; i < maxnumber; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(arraynumbers[i] + " ");
                }
            }
        }
    }
}

