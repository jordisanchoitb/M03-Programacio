using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Motor
    {
        public bool IsActivated { get; set; }
        public int Fuel { get; set; }
        public int ActivacionCode { get; set; }
        public Motor(bool isActivated, int fuel, int activacionCode)
        {
            IsActivated = isActivated;
            Fuel = fuel;
            ActivacionCode = activacionCode;
        }

        public Motor(int fuel, int activacionCode) : this(false, fuel, activacionCode)
        {
        }

        public Motor(int activacionCode) : this(100, activacionCode)
        {
        }

        public Motor() : this(1234)
        {
        }

        public void Activate(int ActivationCode)
        {
            if (ActivationCode != ActivacionCode)
            {
                throw new Exception("Codi de seguretat incorrecte");
            }
            else if (ActivationCode == ActivationCode && Fuel > 50)
            {
                IsActivated = true;
            } else
            {
                throw new Exception("No hi ha prou combustible");
            }
        }

        public void Deactivate()
        {
            IsActivated = false;
        }


        public void Fabricate()
        {
            Console.WriteLine("Motor is fabricated");
        }


    }
}
