/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 

 */
using System;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            int gasoline;
            Car car = new Car(0);
            Console.WriteLine("Enter the amount of gasoline to refuel");
            gasoline = Convert.ToInt32(Console.ReadLine());
            car.Refuel(gasoline);
            car.Drive();
            
        }
    }

    public interface IVehicule
    {
        void Drive();
        bool Refuel(int gasoline);
    }

    public class Car : IVehicule
    {
        private int gasoline;

        /// <summary>
        /// Instantiates a car with a given amount of gasoline
        /// </summary>
        public Car(int gasoline)
        {
            this.gasoline = gasoline;
        }

        /// <summary>
        /// Drives the car if there is gasoline
        /// </summary>
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving");
            }
        }
        /// <summary>
        /// Passes the amount of gasoline to the car
        /// </summary>
        /// <returns>bolean</returns>
        public bool Refuel(int gasoline)
        {
            this.gasoline += gasoline;
            return true;
        }
    }
}