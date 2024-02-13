using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Quadrat : AGeometricFigure
    {
        private double side;
        public Quadrat(string name, double side) : base(name)
        {
            Side = side;
        }
        public double Side
        {
            get { return side; }
            set
            {
                if (value > 0)
                {
                    side = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side must be greater than 0");
                }
            }
        }
        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return Side * 4;
        }
    }
}
