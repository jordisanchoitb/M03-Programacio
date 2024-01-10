/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 27. Implementa un programa que demani a l’usuari que introdueixi un text i el retorni tot en majúscules, 
 * tot en minúscules i la primera lletra de cada paraula en majúscules (per separat).
 *
 */
using System;

namespace Exercici27
{
    public class Exercici27
    {
        public static void Main()
        {
            const string MSGSentence = "Donem un text: ";
            string sentence, uppersentece, lowersentece;


            Console.WriteLine(MSGSentence);
            sentence = Console.ReadLine();

            uppersentece = sentence.ToUpper();
            lowersentece = sentence.ToLower();
            string[] text = sentence.Split(' ');

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = char.ToUpper(text[i][0]) + text[i].Substring(1).ToLower();
            }
            string capitalizesentence = string.Join(" ", text);

            Console.WriteLine();
            Console.WriteLine("Text en majúscules: " + uppersentece);
            Console.WriteLine("Text en minúscules : " + lowersentece);
            Console.WriteLine("Text amb la primera lletra de cada paraula en majúscules: " + capitalizesentence);


        }
    }
}

