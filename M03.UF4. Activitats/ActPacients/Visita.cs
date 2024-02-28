using System;

namespace OOPEx
{
    public class Visita
    {
        public Propietari Propietari { get; set; }
        public Pacient Pacient { get; set; }
        public string DataAvuir { get; set; }
        public string MotiuUrgencia { get; set; }
        public Visita(Propietari propietari, Pacient pacient, string dataAvuir, string motiuUrgencia)
        {
            this.Propietari = propietari;
            this.Pacient = pacient;
            this.DataAvuir = dataAvuir;
            this.MotiuUrgencia = motiuUrgencia;
        }


        public override string ToString()
        {
            return $"|   Data   | Propietaria | Pacient |   Motiu   |\n" +
                "|----------|-------------|---------|-----------|\n" +
                $"| {this.DataAvuir} |    {Propietari.Nom}    |  {Pacient.Nom}  |  {this.MotiuUrgencia} |";
        }

    }
}
