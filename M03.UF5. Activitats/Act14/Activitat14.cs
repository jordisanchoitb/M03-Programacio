/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 
 * 14. Implementa un mètode (diferent per a cada opció) que:
comprovi que una cadena conté només un conjunt determinat de caràcters (en aquest cas a-z, A-Z i 0-9).
comprovi si una cadena conté una a seguida de zero o més b's.
comprovi si una cadena conté una a seguida de dos o tres b's.
trobi seqüències de lletres minúscules unides amb un guió baix

 * 
*/
using System.Text.RegularExpressions;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            
            
        }

        public static bool ContieneCaracteres(string cadena)
        {
            return Regex.IsMatch(cadena, "^[a-zA-Z0-9]+$");
        }

        public static bool ContieneAseguidaDeB(string cadena)
        {
            return Regex.IsMatch(cadena, "[[a][b]*]*");
        }

        public static bool ContieneAseguidaDeDosOTresB(string cadena)
        {
            return Regex.IsMatch(cadena, "a(bb|bbb)");
        }

        public static bool ContieneMinusculasUnidasConGuionBajo(string cadena)
        {
            return Regex.IsMatch(cadena, "[a-z]_[a-z]");
        }
    }
}
