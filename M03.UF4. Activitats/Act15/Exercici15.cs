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

                        

        }
    }

    public class Furniture
    {
        private float weight;
        private double price;
        private bool set;
        private string name, material, colour;

        public Furniture(float weight, double price, bool set, string name, string material, string colour)
        {
            this.weight = weight;
            this.price = price;
            this.set = set;
            this.name = name;
            this.material = material;
            this.colour = colour;
        }

        public Furniture(float weight, double price, string name, string material, string colour)
        {
            this.weight = weight;
            this.price = price;
            this.set = false;
            this.name = name;
            this.material = material;
            this.colour = colour;
        }

        public Furniture()
        {
            this.weight = 0;
            this.price = 0;
            this.set = false;
            this.name = "";
            this.material = "";
            this.colour = "";
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Set
        {
            get { return set; }
            set { set = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public void CalculatePrice()
        {
            
            Console.WriteLine(this.price * 1.21);
        }

        public void CalculatePrice(float weight, double price)
        {
            Console.WriteLine(price * weight);
        }

        public void CalculatePrice(float weight)
        {
            Console.WriteLine(this.price * weight);
        }

    }
}