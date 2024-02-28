using System;

namespace activitats
{
    
    public class Bike
    {
        private string model;
        private string color;
        private int wheels;

        public Bike(string model, string color, int wheels)
        {
            this.model = model;
            this.color = color;
            this.wheels = wheels;
        }

        public string getModel()
        {
            return this.model;
        }
        public string getColor()
        {
            return this.color;
        }

        public int getWheels()
        {
            return this.wheels;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setWheels(int wheels)
        {
            this.wheels = wheels;
        }

        public void printBike()
        {
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Wheels: " + this.wheels);
        }
    }
}
