using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public abstract class AGeometricFigure
    {
        protected string geometricName;
        public AGeometricFigure(string name)
        {
            GeometricName = name;
        }

        protected Colour? ForeColour { get; set; }
        protected Colour? BackColour { get; set; }
        public string GeometricName { get; set; }
        public abstract double Area();
        public abstract double Perimeter();

    }
}
