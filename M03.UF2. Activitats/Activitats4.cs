/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 4. Implementa un mètode que rebi un text i el 
 * retorni a majúscules o a minúscules (segons el cas).
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MSGProgram = "Donem un text i diguem si vols el text en mayusucles o minuscules";
            const string MSGText = "Introdueix el text: ";
            const string MSGUpperOrLower = "Com vols el text en Mayusculas (mayu) o Minusculas (minu)";
            string inputext, upperorlower;
            bool uppercase = true;

            Console.WriteLine(MSGProgram);
            Console.WriteLine(MSGText);
            inputext = Console.ReadLine();
            Console.WriteLine(MSGUpperOrLower);
            upperorlower = Console.ReadLine();
            switch (upperorlower.ToLower())
            {
                case "mayu":
                    uppercase = true;
                    break;
                case "minu":
                    uppercase = false;
                    break;
            }
            Console.WriteLine(UpperCase(inputext, uppercase));
        }
        public static string UpperCase(string text, bool uppercase)
        {
            return uppercase ? text.ToUpper() : text.ToLower();
        }
    }
}