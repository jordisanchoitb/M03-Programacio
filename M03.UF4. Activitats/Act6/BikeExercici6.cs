using System;

namespace OOPEx
{
    public class BikeExercici6 : VehicleWheeled
    {
        private string name;
        private string type;

        public BikeExercici6(string matricula, string model, string color, int anyFabricacio, int numWheels, int maxSpeed, string name, string type) : base(matricula, model, color, anyFabricacio, numWheels, maxSpeed)
        {
            this.name = name;
            this.type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }


    }
}
