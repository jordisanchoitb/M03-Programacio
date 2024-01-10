using System;
using System.Runtime.InteropServices;

namespace calcgrades
{
    public class calcgrades
    {
        public static void Main()
        {
            int usernumber;

            Console.WriteLine("Donem el numero del dia de la semana i et retorno quin dia de la semana es, ejemple (1:Dillluns, 2:Dimarts,...)");
            Console.WriteLine("");
            Console.WriteLine("Introdueix el numero: ");

            usernumber = Convert.ToInt32(Console.ReadLine());

            switch (usernumber)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Dijous");
                    break;
                case 5:
                    Console.WriteLine("Divendres");
                    break;
                case 6:
                    Console.WriteLine("Disabte");
                    break;
                case 7:
                    Console.WriteLine("Diumenge");
                    break;
                default: 
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
