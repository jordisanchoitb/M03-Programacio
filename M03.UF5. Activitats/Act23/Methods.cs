using System;

namespace OOPEx
{
    public static class Methods
    {
        public static int Fibonnaci(int fibonnaci)
        { 
            if (fibonnaci == 0) return 0;
            if (fibonnaci == 1) return 1;
            return Fibonnaci(fibonnaci - 1) + Fibonnaci(fibonnaci - 2);
        }

    }
}
