using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace OOPEx
{
    public class SubCommander : Crew, IFlyable
    {
        public bool IsPiloting { get; set; }
        public SubCommander(string name, int age) : base(name, age)
        {
            IsPiloting = false;
        }

        public bool ImPiloting()
        {
            if (IsPiloting)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
