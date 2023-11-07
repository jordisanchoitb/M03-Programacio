/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 26. Implementa un programa que demani a l’usuari que introdueixi un text i retorni la seva longitud.
 *
 */

namespace Exercici26
{
    public class Exercici26
    {
        public static void Main()
        {
            const string MSGSentence = "Donem una frase: ";
            string sentence;


            Console.WriteLine(MSGSentence);
            sentence1 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Te una longitud de: {sentence.Length}");

        }
    }
}

