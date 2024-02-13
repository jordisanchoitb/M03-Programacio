using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Iguana : AAnimal
    {
        public Iguana(string name, int age, string type) : base(name, age, type) { }
        public override void MakeSound()
        {
            Console.WriteLine($"I am {this.name} and I make iguana sounds");
        }

        public void Climb()
        {
            Console.WriteLine($"I am {this.name} and I am climbing");
        }

        public void ChangeColor()
        {
            Console.WriteLine($"I am {this.name} and I am changing color");
        }
    }
}
