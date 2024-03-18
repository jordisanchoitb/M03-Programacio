/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 
 * 
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
