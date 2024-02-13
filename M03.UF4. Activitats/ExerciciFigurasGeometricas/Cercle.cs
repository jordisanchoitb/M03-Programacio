using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Cercle : AGeometricFigure
    {
        private double radius;
        public Cercle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Radius must be greater than 0");
                }
            }
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
