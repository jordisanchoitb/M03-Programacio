using System;

namespace oddandeven
{
    public class oddandeven
    {
        public static void Main()
        {
            // impar odd i par even
            int number, odd=0, even=0, lenghNumber=0, calc;
            Console.WriteLine("Donem un numero i et retorno quants digits te i el digits parells el sumo entre si al mateix amb els imparells: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 9)
            {
                while (number > 9 ) 
                {
                    calc = number / 10;
                    if (calc % 2 == 0)
                    {
                        even += calc;
                    }   else
                    {
                        odd += calc;
                    }
                    lenghNumber++;
                    number /= 10;
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    even += even;
                }
                else 
                {
                    odd += odd;
                }
                lenghNumber++;
            }
            Console.WriteLine("Te " + lenghNumber + " digits, la suma del valors parells es " + even + " i la dels valors imparells es: " + odd);
        }
    }
}
