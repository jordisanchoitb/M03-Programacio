using System;
using OOPEx;

namespace Activitats
{
    public class AVehicle
    {
        protected string matricula;
        protected string model;
        protected string color;
        protected int anyFabricacio;

        public AVehicle(string matricula, string model, string color, int anyFabricacio)
        {
            this.matricula = matricula;
            this.model = model;
            this.color = color;
            this.anyFabricacio = anyFabricacio;
        }

        public string Matricula { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int AnyFabricacio { get; set; }
            
    }
}