/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * 
 * Exercici 3. Implementa un programa que demani el nom d’un fitxer de text i que retorni per consola el nombre de línies que aquest conté.
 */

using System;
using System.IO;

namespace Program
{
    public static class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "El document te un total de {0} lineas.";

            Console.WriteLine("Introdueix el nom del fitxer: ");
            string fileName = Console.ReadLine();

            string path = Path.GetFullPath(@"..\..\..\files\" + fileName);

            string[] lines = File.ReadAllLines(path);

            Console.WriteLine(MsgWelcome,lines.Length);

            
        }
    }
}