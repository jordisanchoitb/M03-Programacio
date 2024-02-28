using System;

namespace activitats
{
    public class Cat
    {
        private string name;
        private int age;
        private string breed;
        private string favoriteFood;

        public Cat(string name, int age, string breed, string favoriteFood)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.favoriteFood = favoriteFood;
        }

        public void SetName(int age)
        {
            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetBreed(string breed)
        {
            this.breed = breed;
        }

        public string GetBreed()
        {
            return this.breed;
        }

        public void SetFavoriteFood(string favoriteFood)
        {
            this.favoriteFood = favoriteFood;
        }

        public string GetFavoriteFood()
        {
            return this.favoriteFood;
        }

        public void MakeMeowSound()
        {
            Console.WriteLine("Meow!");
        }

        public void Play()
        {
            Console.WriteLine("Playing...");
        }

        public void Wash()
        {
            Console.WriteLine("Washing...");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Hunt()
        {
            Console.WriteLine("Hunting...");
        }
    }
}
