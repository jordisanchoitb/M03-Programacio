using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class LandingSystem
    {
        public bool IsActivated { get; set; }
        public ExpertSystem ExpertSystem { get; set; }
        public LandingSystem()
        {
            IsActivated = false;
            ExpertSystem = new ExpertSystem();
        }
    }
}
