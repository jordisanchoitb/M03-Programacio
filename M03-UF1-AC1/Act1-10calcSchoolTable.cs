using System;

namespace calcSchoolTable
{
    public class calcSchoolTable
    {
        public static void Main()
        {
            int number, numbertables=0;
            bool whileverif;
           

            Console.WriteLine("Donem el numero de alumnes de les clases i et retorno quantes taules necesiteu en total: ");
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number >= 0)
                    {
                        if (number%2 == 0)
                        {
                            numbertables += number / 2;
                        } else
                        {
                            numbertables += (number / 2) + 1;
                        }
                        whileverif = false;
                    }
                    else
                    {
                        Console.WriteLine("No has introduit un numero enter, torna a introduir-lo: ");
                        whileverif = true;
                    }
                } while (whileverif);
            }
            Console.WriteLine("Les taules que necesiteu son: " + numbertables);
        }   
    }
}