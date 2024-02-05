/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * 
 * Exercici 2. Implementa un programa que mostri per consola només la primera línia del document de text introduït per teclat. Aquest contindrà el següent text (cal mantenir el format):
"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
 */

using System;
using System.IO;

namespace Program
{
    public static class Program
    {
        public static void Main()
        {
            const string MsgWelcome = "La primera línia del document és: ";

            Console.WriteLine("Introdueix el nom del fitxer: ");
            string fileName = Console.ReadLine();
	    
            string path = Path.GetFullPath(@"..\..\..\files\" + fileName);
	    
            string[] lines = File.ReadAllLines(path);
	    // lines.ReadLine();
	    // puedes leer la primera linea del archivo con readline
            Console.WriteLine(MsgWelcome + lines[0]);

            
        }

        
    }
}