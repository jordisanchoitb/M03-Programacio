using System;

namespace gamesecretnumber
{
    public class gamesecretnumber
    {
        public static void Main()
        {
            Random random = new Random();
            int attempts = 10, secretnumber = random.Next(1,100), usernumber;
            string answer;

            Console.WriteLine("Vols jugar a un joc per endevinar el numero secret unicament amb 10 intents, introdueix (jugar) en cas de voler jugar i (sortir) en cas de voler sortir del programa");
            answer = Console.ReadLine();

            if (answer == "jugar")
            {
                Console.WriteLine("Has entrat a jugar");
                
                do
                {
                    Console.Write("Introdueix el numero: ");
                    usernumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (usernumber != secretnumber)
                    {
                        if (usernumber > secretnumber)
                        {
                            Console.WriteLine("No has introduit el numero correcte");
                            Console.WriteLine("El nombre secret es mes petit");
                        } else
                        {
                            Console.WriteLine("No has introduit el numero correcte");
                            Console.WriteLine("El nombre secret es mes gran");
                        }
                    }
                    attempts--;

                } while (attempts > 0 && usernumber != secretnumber);
                if (attempts > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Has endevinat el numero secret");
                } else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Has perdut el 10 intents senser endevinar el numero, el numero secret era " + secretnumber);
                }

            }
            else if (answer == "salir")
            {
                Console.WriteLine("Has sortit del joc");
            }

        }
    }
}
