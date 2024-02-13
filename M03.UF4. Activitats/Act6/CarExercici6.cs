using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class CarExercici6 : VehicleWheeled, IVehiclePlaces
    {
        private int places;
        private string fuel;

        public CarExercici6(string matricula, string model, string color, int anyFabricacio, int numWheels, int maxSpeed, int places, string fuel) : base(matricula, model, color, anyFabricacio, numWheels, maxSpeed)
        {
            this.places = places;
            this.fuel = fuel;
        } 
        public int Places { get; set; }
        public string Fuel { get; set; }
    }
}
