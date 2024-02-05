/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * 
 * Exercici 1. Prova els diferents exemples de manipulació de fitxers que trobaràs al repositori. Afegeix:
 control d’excepcions 
que l’usuari pugui introduir el nom del fitxer (si no introdueix un .txt l’ha de tornar a introduir, sense límit d’intents)
en el cas d’escriptura, que insereixi i afegeixi un text indicat per l’usuari

 */

using System;
using System.IO;

namespace Program
{
    public static class Program
    {
        public static void Main()
        {
            string inputfile;
            bool txtError = false;
            Console.WriteLine("Introdueix el nom del fitxer");
            do 
            {
                if (txtError)
                {
                    Console.WriteLine("El fitxer ha de ser de extensio .txt");
                }
                inputfile = Console.ReadLine() ?? "";
            } while (!inputfile.EndsWith(".txt"));
            Console.WriteLine("Que vols fer? Llegir o escriure? (l/e)");
            string option = Console.ReadLine() ?? "";
            if (option == "e")
            {
                WriteFile(inputfile);
            } else
            {
                ReadFile(inputfile);
            }
        }

        public static void ReadFile(string file)
        {
            string path = Path.GetFullPath(@"..\..\..\files\" + file);
            try
            {
                using StreamReader sr = File.OpenText(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            } catch (FileNotFoundException e)
            {
                Console.WriteLine($"El fitxer no existeix: {e}");
                Console.WriteLine("Et creo el fitxer");
                if (!File.Exists(path))
                {
                    string createText = "Hello world!" + Environment.NewLine;
                    File.WriteAllText(path, createText);

                    string appendText = "Nova línia" + Environment.NewLine;
                    File.AppendAllText(path, appendText);
                }
                Console.WriteLine("Fitxer creat");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }             
        }

        public static void WriteFile(string file)
        {
            string path = Path.GetFullPath(@"..\..\..\files\" + file);
            try
            {
                using StreamWriter sw = File.AppendText(path);
                Console.WriteLine("Introdueix el text que vols afegir");
                string text = Console.ReadLine() ?? "";
                sw.WriteLine(text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"El fitxer no existeix: {e}");
                Console.WriteLine("Et creo el fitxer");
                if (!File.Exists(path))
                {
                    string createText = "Hello world!" + Environment.NewLine;
                    File.WriteAllText(path, createText);

                    string appendText = "Nova línia" + Environment.NewLine;
                    File.AppendAllText(path, appendText);
                }
                Console.WriteLine("Fitxer creat");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}