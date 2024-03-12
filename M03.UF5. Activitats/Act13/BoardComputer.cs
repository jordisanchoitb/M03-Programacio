using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class BoardComputer
    {
        public bool IsActivated { get; set; }
        public AI AI { get; set; }
        public BoardComputer()
        {
            IsActivated = false;
            AI = new AI();
        }
    }
}
