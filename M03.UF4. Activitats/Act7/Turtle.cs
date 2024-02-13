using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Turtle : AAnimal
    {
        public Turtle(string name, int age, string type) : base(name, age, type) { }
        public override void MakeSound()
        {
            Console.WriteLine($"I am {this.name} and I make turtle sounds");
        }

        public void Swim()
        {
            Console.WriteLine($"I am {this.name} and I am swimming");
        }

        public void HideInShell()
        {
            Console.WriteLine($"I am {this.name} and I am hiding in my shell");
        }
    }
}
