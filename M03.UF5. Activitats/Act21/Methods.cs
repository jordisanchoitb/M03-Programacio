using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public static class Methods
    {
        public static int Media(int[] arraynumber)
        {
            int sum = 0;
            for (int i = 0; i < arraynumber.Length; i++)
            {
                sum += arraynumber[i];
            }
            return sum / arraynumber.Length;
        }

    }
}
