using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public abstract class AAnimal
    {
        protected string name;
        protected int age;
        protected string type;
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        
        public AAnimal(string name, int age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }

        public abstract void MakeSound();
    }
}
