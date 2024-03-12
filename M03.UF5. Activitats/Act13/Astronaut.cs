using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Astronaut : Crew
    {
        public bool IsInSpaceSuit { get; set; }
        public Astronaut(string name, int age) : base(name, age)
        {
            IsInSpaceSuit = false;
        }
    }
}
