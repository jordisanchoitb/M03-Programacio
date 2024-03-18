using System;

namespace OOPEx
{
    public class Visita
    {
        public Propietari Propietari { get; set; }
        public Pacient Pacient { get; set; }
        public DateTime DataAvui { get; set; }
        public string MotiuUrgencia { get; set; }
        public Visita(Propietari propietari, Pacient pacient, DateTime dataAvuir, string motiuUrgencia)
        {
            this.Propietari = propietari;
            this.Pacient = pacient;
            this.DataAvui = dataAvuir;
            this.MotiuUrgencia = motiuUrgencia;
        }

        public Visita(Propietari propietari, Pacient pacient, string motiuUrgencia) : this (propietari, pacient, DateTime.Now, motiuUrgencia)
        { 
        }

        public override string ToString()
        {
            return $"| {this.DataAvui,-8} |    {Propietari.Nom}    |  {Pacient.Nom}  |  {this.MotiuUrgencia} |";
        }

    }
}
