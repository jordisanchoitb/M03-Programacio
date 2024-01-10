/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * 4. Implementa el mètode anterior però en aquest cas haurà de validar 
 * si el valor és dins del rang de valors introduïts per teclat 
 */

using System;

namespace Ex4
{
    public class Ex4
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix un numero que vols comprovar si esta dins del rang:";
            const string MsgMinRang = "Introdueix el valor minim del rang:";
            const string MsgMaxRang = "Introdueix el valor maxim del rang:";
            const string MsgIsInRange = "El numero introduit esta dins del rang";
            const string MsgIsNotInRange = "El numero introduit esta fora del rang";

            int usernumber, maxrang, minrang;
            Console.WriteLine(MsgProgram);
            usernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgMinRang);
            minrang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgMaxRang);
            maxrang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsInRange(usernumber, maxrang, minrang) ? MsgIsInRange : MsgIsNotInRange);
            
        }
        
        public static bool IsInRange(int usernumber, int maxrang, int minrang)
        {
            if (usernumber < maxrang && usernumber >= minrang)
            {
                 return true;
            }
            return false;
        }
    }
}