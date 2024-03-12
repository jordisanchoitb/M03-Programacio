using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Pacient
    {
        public string Nom { get; set; }
        public string Rassa { get; set; }
        public int Edat { get; set; }
        public bool Vacunat { get; set; }


        public Pacient(string nom, string rassa, int edat, bool vacunat)
        {
            this.Nom = nom;
            this.Rassa = rassa;
            this.Edat = edat;
            this.Vacunat = vacunat;
        }



    }
}
