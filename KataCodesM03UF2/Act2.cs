/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * 2. Implementa un mètode que retorni el valor absolut de l'argument rebut.
 * NO es pot fer servir la classe Math.
 */

using System;

namespace Ex2
{
    public class Ex2
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix un numero i et retorno el seu valor absolut";
            const string MsgResult = "El nombre absolut es: {0}";
            int usernumber;
            Console.WriteLine(MsgProgram);
            usernumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgResult, AbsoluteValue(usernumber));
        }

        public static int AbsoluteValue(int usernumber)
        {
            if (usernumber < 0)
            {
                usernumber = usernumber * -1;
            }
            return usernumber;
        }
    }
}