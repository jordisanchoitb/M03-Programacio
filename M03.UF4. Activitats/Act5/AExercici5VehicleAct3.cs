using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class AExercici5Vehicle
    {
        protected string model;
        protected string color;
        protected int wheels;

        public AExercici5Vehicle(string model, string color, int wheels)
        {
            this.model = model;
            this.color = color;
            this.wheels = wheels;
        }

        public string getModel() => this.model;
        public string getColor() => this.color;

        public int getWheels() => this.wheels;

        public void setModel(string model) => this.model = model;

        public void setColor(string color) => this.color = color;

        public void setWheels(int wheels) => this.wheels = wheels;

        public void printVehicle()
        {
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Wheels: " + this.wheels);
        }
    }
}
