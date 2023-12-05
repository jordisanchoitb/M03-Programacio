/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 8. Implementa un mètode que retorni
 * 10 nombres al·leatoris entre 0 i 256.  
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            TenRandomNumbers();
        }
         
        public static void TenRandomNumbers()
        {
            const int numbers = 10;
            Random random = new Random();
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine(random.Next(257));
            }
        }
    }
}