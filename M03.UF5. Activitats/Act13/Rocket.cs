using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Rocket
    {
        public int Angle { get; set; }
        public bool IsLaunched { get; set; }
        public Motor Motor1 { get; set; }
        public Motor Motor2 { get; set; }
        public NavigationSystem NavigationSystem { get; set; }
        public Rocket(NavigationSystem navigationSystem)
        {
            IsLaunched = false;
            Motor1 = new Motor();
            Motor2 = new Motor();
            Angle = 0;
            NavigationSystem = navigationSystem;
        }
        public void Ignicion(char letter, int ActivationCode)
        {
            if (letter == 'T')
            {
                Motor1.Activate(ActivationCode);
                Motor2.Activate(ActivationCode);
            } else
            {
                Motor1.Deactivate();
                Motor2.Deactivate();
            }
        }

        public void UpdateAngle()
        {
            NavigationSystem.UpdateGyroscopeInclination();
            Angle += NavigationSystem.GyroscopeInclination;
        }
    }
}
