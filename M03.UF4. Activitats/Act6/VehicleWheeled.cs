using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activitats;

namespace OOPEx
{
    public class VehicleWheeled : AVehicle
    {
        protected int numWheels;
        protected int maxSpeed;

        public VehicleWheeled(string matricula, string model, string color, int anyFabricacio, int numWheels, int maxSpeed) : base(matricula, model, color, anyFabricacio)
        {
            this.numWheels = numWheels;
            this.maxSpeed = maxSpeed;
        }

        public int NumWheels { get; set; }
        public string Type { get; set; }
        public string Fuel { get; set; }
        public int MaxSpeed { get; set; }


    }
}
