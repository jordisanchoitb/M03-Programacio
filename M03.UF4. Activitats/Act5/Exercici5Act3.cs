using System;
using OOPEx;

namespace activitats
{

    public class Bike : AExercici5Vehicle
    {
        private string name;

        public Bike(string model, string color, int wheels, string name) : base(model, color, wheels)
        {
            this.name = name;
        }

        public string GetName() => this.name;
        public string SetName(string name) => this.name = name;

        public void PrintInfoBike()
        {
            Console.WriteLine("Name: " + this.name);
            printVehicle();
        }


    }
}
