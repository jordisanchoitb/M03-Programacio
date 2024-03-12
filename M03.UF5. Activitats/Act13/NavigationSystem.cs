using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class NavigationSystem
    {
        public bool IsActivated { get; set; }
        public int GyroscopeInclination { get; set; }
        public NavigationSystem()
        {
            IsActivated = false;
            GyroscopeInclination = GetAleatoriGyroscopeInclination();
        }
        public int GetAleatoriGyroscopeInclination()
        {
            return new Random().Next(1, 46);
        }

        public void UpdateGyroscopeInclination()
        {
            GyroscopeInclination = GetAleatoriGyroscopeInclination();
        }
    }
}
