using System;

namespace Exercici12
{
    class Exercici12
    {
        static void Main()
        {
            const string MSGStartProgram = "Donem 20 numeros i et separo en dos files els que son parells i els que son imparells: ";

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
                if (arraynumbers[i] % 2 == 0)
                {
                    Console.Write(arraynumbers[i] + " ");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 0; i < maxnumber; i++)
            {
                if (arraynumbers[i] % 2 != 0)
                {
                    Console.Write(arraynumbers[i] + " ");
                }
            }
        }
    }
}

