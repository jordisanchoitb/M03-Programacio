using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace OOPEx
{
    public class AI : IFlyable
    {
        public bool IsActivated { get; set; }
        public bool IsPiloting { get; set; }
        public AI()
        {
            IsActivated = false;
            IsPiloting = false;
        }

        public bool ImPiloting()
        {
            if (IsPiloting)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
