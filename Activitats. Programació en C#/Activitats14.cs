using System;

namespace Exercici14
{
    class Exercici14
    {
        static void Main()
        {
            const string MSGStartProgram = "Donem 20 numeros d'entre el 1 i el 9 inclosos i et retorno els numeros introduits de esquerra a dreta i despres al reves: ";
            const string MSGErrorNumber = "Error. El numero que has introduit no esta dins del rang dentre 1 i 9 inclosos ells, Torna ha internarlo: ";
	    const int maxnumber = 20;
	    int usernumber; 
            bool errornumber;

            int[] arraynumbers = new int[maxnumber];


            Console.WriteLine(MSGStartProgram);

            for (int i = 0; i < maxnumber; i++)
            {
                errornumber = false;
                do
                { 
                    if (errornumber)
                    {
                        Console.WriteLine(MSGErrorNumber);
                    }
                    usernumber = Convert.ToInt32(Console.ReadLine());
                    if (!(usernumber >= 1 && usernumber <= 9))
                    {
                        errornumber = true;
                    }
                } while (!(usernumber >= 1 && usernumber <= 9));

                arraynumbers[i] = usernumber;
            }

            Console.WriteLine("");

            for (int i = 0; i < maxnumber; i++)
            {
                Console.Write(arraynumbers[i] + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = maxnumber - 1; i >= 0; i--) 
            {
                Console.Write(arraynumbers[i] + " ");
            }


        }
    }
}

