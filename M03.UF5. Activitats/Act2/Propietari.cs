using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Propietari
    {
        public string Nom { get; set; }
        public string Cognom { get; set; }
        public string Dni { get; set; }
        public int Telf { get; set; }
        public Propietari(string nom, string cognom, string dni, int telf)
        {
            this.Nom = nom;
            this.Cognom = cognom;
            this.Dni = dni;
            this.Telf = telf;
        }


    }
}
