/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * Endevinalla!
Implementa un programa en C# en el qual demani a l'usuari un número de 
l'1 al 100 i el programa disposarà de 10 intents per a endevinar-lo.
El programa haurà de pensar un número aleatori i preguntar si ha encertat. 
L'usuari només podrà indicar si és major, menor o igual a cada intent.
 */

using System;

namespace Endevinalla
{
    public class Endevinalla
    {
        public static void Main()
        {
            const string MsgError = "No has introduit una opcio valida, torna a introduir un valor:";
            const string MsgNumberOcult = "El numero ocult es {0}";
            const string MsgNumberOp = "El numero ocult es major, menor o igual?";
            const string MsgCorrect = "He encertat el numero ocult que era el {0}";
            const string MsgIncorrect = "No he encertat el numero ocult";
            const int maxtrys = 10;
            string userinput;
            int trys=0, rangmin=1, rangmax=101, aleatorynumber;
            bool found = false;

            while (trys < maxtrys && !(found))
            {
                aleatorynumber = RandomNumberGenerator(rangmin, rangmax);
                Console.WriteLine(MsgNumberOcult, aleatorynumber);
                Console.WriteLine(MsgNumberOp);
                do 
                {
                    userinput = Console.ReadLine().ToLower();
                    switch (userinput)
                    {
                        case "major":
                            rangmin = aleatorynumber+1;
                            break;
                        case "menor":
                            rangmax = aleatorynumber;
                            break;
                        case "igual":
                            Console.WriteLine(MsgCorrect, aleatorynumber);
                            found = true;
                            break;
                        default:
                            Console.WriteLine(MsgError);
                            break;
                    }
                } while (CheckInput(userinput));
                trys++;
            }
            if (trys == maxtrys && !(found))
            {
                Console.WriteLine(MsgIncorrect);
            }
        }

        public static int RandomNumberGenerator(int rangmin, int rangmax)
        {
            Random rnd = new Random();
            int aleatorynumber = rnd.Next(rangmin, rangmax);
            return aleatorynumber;
        }

        public static bool CheckInput(string userinput)
        {
            bool inputerror = true;
            if (userinput == "major" || userinput == "menor" || userinput == "igual")
            {
                inputerror = false;
            }
            return inputerror;
        }
    }
}