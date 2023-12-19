/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * 3. Implementa un mètode que retorni si 
 * el valor que rep com a argument és més petit que 2 (ha de retornar T o F) 
 */

using System;

namespace Ex3
{
    public class Ex3
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix un numero";
            const string MsgGreaterTo2 = "El nombre es mes gran que 2";
            const string MsgSmallerThan2 = "El nombre es mes petit que 2";
            int usernumber;
            Console.WriteLine(MsgProgram);
            usernumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GreaterThan2(usernumber) ? MsgGreaterTo2 : MsgSmallerThan2);
        }
        public static bool GreaterThan2(int usernumber)
        {
            if (usernumber > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}