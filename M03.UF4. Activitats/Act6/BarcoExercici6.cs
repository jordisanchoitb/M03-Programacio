using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activitats;

namespace OOPEx
{
    public class BarcoExercici6 : AVehicle
    {
        private int anylastRevisio;
        
        public BarcoExercici6(string matricula, string model, string color, int anyFabricacio, int anylastRevisio) : base(matricula, model, color, anyFabricacio)
        {
            this.anylastRevisio = anylastRevisio;
        }

        public int AnylastRevisio { get; set; }

    }
}
