using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Wolf : AAnimal
    {
        public Wolf(string name, int age, string type) : base(name, age, type) { }
        public override void MakeSound()
        {
            Console.WriteLine($"I am {this.name} and I make awooo sounds");
        }

        public void Hunt()
        {
            Console.WriteLine($"I am {this.name} and I am hunting");
        }

        public void Howl()
        {
            Console.WriteLine($"I am {this.name} and I am howling");
        }
    }
}
