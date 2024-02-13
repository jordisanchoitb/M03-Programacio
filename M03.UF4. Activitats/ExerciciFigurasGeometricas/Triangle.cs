using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Triangle : AGeometricFigure
    {
        private double side;
        private double height;
        
        public Triangle(string name, double side, double height) : base(name)
        {
            Side = side;
            Height = height;
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
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than 0");
                }
            }
        }
        public override double Area()
        {
            return (Side * Height) / 2;
        }

        public override double Perimeter()
        {
            return Side * 3;
        }
    }
}
