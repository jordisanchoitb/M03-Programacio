using System;

namespace activitats
{
    public class Persona
    {
        private string name;
        private string surname;
        private int age;
        private string dni;
        private double height;
        private int weight;

        public Persona(string name, string surname, int age, string dni, double height, int weight)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.dni = dni;
            this.height = height;
            this.weight = weight;
        }

        public void setName(string name) { this.name = name;}
        public string getName() { return this.name;}
        public void setSurname(string surname) { this.surname = surname;}
        public string getSurname() { return this.surname;}
        public void setAge(int age) { this.age = age;}
        public int getAge() { return this.age;}
        public void setDni(string dni) { this.dni = dni;}
        public string getDni() { return this.dni;}
        public void setHeight(double height) { this.height = height;}
        public double getHeight() { return this.height;}
        public void setWeight(int weight) { this.weight = weight;}
        public int getWeight() { return this.weight;}

        public void PrintAllInfoPerson()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Surname: " + this.surname);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("DNI: " + this.dni);
            Console.WriteLine("Height: " + this.height);
            Console.WriteLine("Weight: " + this.weight);
        }
    }
}
