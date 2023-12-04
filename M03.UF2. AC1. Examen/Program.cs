using System;

namespace JordiSancho
{
    public class Examen
    {
        public static void Main()
        {
            const string MSGAge = "Donem la teva edad";
            const string MSGUsername = "Donem el teu nom";
            const string MSGGetAge = "Vols dir la teva edad (si) o (no)?";
            const string MSGError = "Error, no has introduit un valor correcta";

            int age;
            string username, inputage;

            Console.WriteLine(MSGUsername);
            username = Console.ReadLine();

            Console.WriteLine(MSGGetAge);
            inputage = Console.ReadLine();

            if (inputage.ToLower() == "si")
            {
                Console.WriteLine(MSGAge);
                age = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(MsgUser(username, age));
            } else if (inputage.ToLower() == "no")
            {
                Console.WriteLine(MsgUser(username));
                
            } else
            {
                Console.WriteLine(MSGError);
            }

        }

        public static string MsgUser(string username)
        {
            return ($"Hola {username}!");
        }
        public static string MsgUser(string username, int age)
        {
            if (age < 5) 
            { 
                return ($"Hola {username}!");
            } else if (age >= 5 && age < 18)
            {
                return ($"Hola {username}! En ser menor d’edat, necessites autorització signada.");
            }
            else
            {
                return ($"Hola {username}! Tens {age} anys");
            }
        }
    }
}