namespace killBlueorRed
{
    public class killBlueorRed
    {
        public static void Main()
        {
            const string guion = "-";
            int hp, attkRammus, attkTwitch, caseprova, killtimerounds;
            Console.WriteLine("En aquest programa mirarem qui mata abans el monstre de la JG.");
            Console.Write("Introdueix el numero de casos de prova que vols fer: ");
            caseprova = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < 60; j++)
            {
                Console.Write(guion);
            }
            Console.WriteLine("");

            for (int i = 0; i < caseprova; i++)
            {
                killtimerounds = 0;
                string whokill = "RAMMUS";
                Console.Write("Introdueix el hp del blue o el red: ");
                hp = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introdueix el atk del Rammus: ");
                attkRammus = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introdueix el atk del Twitch: ");
                attkTwitch = Convert.ToInt32(Console.ReadLine());

                do
                {
                    hp -= attkRammus;
                    if (hp > 0)
                    {
                        hp -= attkTwitch;
                        if (hp <= 0)
                        {
                            whokill = "TWITCH";
                        }
                    }

                    killtimerounds++;
                } while (hp > 0);
                Console.WriteLine("");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(guion);
                }
                Console.WriteLine("");
                Console.WriteLine(whokill + " " + killtimerounds);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(guion);
                }
                Console.WriteLine("");
            }
        }
    }
}