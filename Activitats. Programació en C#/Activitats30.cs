/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 30. ABBA va ser un grup suec de música pop que es va crear a Estocolm l'any 1972, però la fama li va arribar l'any 1974 en guanyar el Festival de la Cançó d'Eurovisió 
 * d'aquell any amb la seva cançó Waterloo. Van aprofitar aquell moment per encadenar un èxit darrere un altre fins a convertir-se en la banda amb més vendes de la dècada dels setanta.
 * El grup va destacar també pel seu atrevit vestuari, extravagant i molt colorit. El nom del grup tampoc deixava indiferent, ja que estava compost per 
 * les inicials dels quatre membres del grup: Agneta, Björn, Benny i Anni-Frid.
 */

using System;

namespace Exercici30
{
    public class Exercici30
    {
        public static void Main()
        {
            string MSGStart = "Introdueix els membres del grup: ";
            string namegroup = "";

            Console.WriteLine(MSGStart);
            Console.WriteLine();
            string userinput = Console.ReadLine();
            // Primer transformo en minusculas tota la string per despres poder treure els accens
            string userinputlower = userinput.ToLower();
            string[] words = userinputlower.Split(", ");
            string[] wordsi = userinputlower.Split(" i ");
            if (words.Length >= 2 && words.Length <= 15)
            {
                foreach (string member in words)
                {
                    string memberWithoutAccents = "";
                    foreach (char c in member)
                    {
                        switch (c)
                        {
                            case 'á':
                            case 'à':
                                memberWithoutAccents += 'a';
                                break;
                            case 'é':
                            case 'è':
                                memberWithoutAccents += 'e';
                                break;
                            case 'í':
                            case 'ì':
                                memberWithoutAccents += 'i';
                                break;
                            case 'ó':
                            case 'ò':
			    case 'ö':
                                memberWithoutAccents += 'o';
                                break;
                            case 'ú':
                            case 'ù':
                            case 'ü':
                                memberWithoutAccents += 'u';
                                break;
                            default:
                                memberWithoutAccents += c;
                                break;
                        }
                    }
                    namegroup += memberWithoutAccents[0].ToString().ToUpper();
                }
                string lastMemberWithoutAccents = "";
                foreach (char c in wordsi[1])
                {
                    switch (c)
                    {
                        case 'á':
                        case 'à':
                            lastMemberWithoutAccents += 'a';
                            break;
                        case 'é':
                        case 'è':
                            lastMemberWithoutAccents += 'e';
                            break;
                        case 'í':
                        case 'ì':
                            lastMemberWithoutAccents += 'i';
                            break;
                        case 'ó':
                        case 'ò':
			case 'ö':
                            lastMemberWithoutAccents += 'o';
                            break;
                        case 'ú':
                        case 'ù':
                        case 'ü':
                            lastMemberWithoutAccents += 'u';
                            break;
                        default:
                            lastMemberWithoutAccents += c;
                            break;
                    }
                }
                namegroup += lastMemberWithoutAccents[0].ToString().ToUpper();

                Console.WriteLine(namegroup);
            }
            else
            {
                Console.WriteLine("El grup ha de tenir com a minim 2 membres i maxim 15 membres.");
            }
        }
    }
}
