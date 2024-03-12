using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public abstract class Crew
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsOnBoard { get; set; }

        public Crew(string name, int age)
        {
            Name = name;
            Age = age;
            IsOnBoard = false;
        }
    }
}
