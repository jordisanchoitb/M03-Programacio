/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 25. Implementa un programa que emmagatzemi una frase introduïda per teclat en la variable textOne. Demana un altre text i emmagatzema’l en la variable textTwo. 
 * Afegeix textTwo a textOne i mostra-la per pantalla. És correcte? Què pots observar a les variables textOne i textTwo?

 *
 */

namespace Exercici25
{
    public class Exercici25
    {
        public static void Main()
        {
            const string MSGSentence1 = "Donem una frase: ";
            const string MSGSentence2 = "Donem una altre frase: ";
            string sentence1, sentence2;


            Console.WriteLine(MSGSentence1);
            sentence1 = Console.ReadLine();
            Console.WriteLine(MSGSentence2);
            sentence2 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(sentence1+sentence2);

            /* 
            * es correcta pero las frases estan juntes sense separacio entre ellas necesitaria posar un espai 
            * al final de la primera frase o un espai al principi de la segona o jo posar un espai entre las dos frases
            */
        }
    }
}

