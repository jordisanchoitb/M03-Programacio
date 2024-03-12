using System;

namespace OOPEx
{
    public class Visita
    {
        public Propietari Propietari { get; set; }
        public Pacient Pacient { get; set; }
        public DateTime DataAvuir { get; set; }
        public string MotiuUrgencia { get; set; }
        public Visita(Propietari propietari, Pacient pacient, DateTime dataAvuir, string motiuUrgencia)
        {
            this.Propietari = propietari;
            this.Pacient = pacient;
            this.DataAvuir = dataAvuir;
            this.MotiuUrgencia = motiuUrgencia;
        }

        public Visita(Propietari propietari, Pacient pacient, string motiuUrgencia)
        {
            this.Propietari = propietari;
            this.Pacient = pacient;
            this.DataAvuir = DateTime.Now;
            this.MotiuUrgencia = motiuUrgencia;
        }

        public override string ToString()
        {
            return $"|   Data   | Propietaria | Pacient |   Motiu   |\n" +
                "|----------|-------------|---------|-----------|\n" +
                $"| {this.DataAvuir,-8} |    {Propietari.Nom}    |  {Pacient.Nom}  |  {this.MotiuUrgencia} |";
        }

    }
}
