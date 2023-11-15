/* 
    Autor: Jordi Sancho
    Data: 15/11/2023
    5. Implementa un menú que demani per teclat introduir una de les següents opcions: 
    A, B, C, D (éssent vàlida tant majúscula com minúscula), com el següent exemple:
    A: l’usuari haurà d’introduir un text i la cadena a buscar dins d’aquest text. El programa haurà de retornar si la cadena és dins del text o no.
    B: l’usuari haurà d’introduir un text i el programa retornarà cada lletra del text separada per un espai.
    Exemple: 
    Entrada: Mira qui balla          Sortida:  M i r a q u i b a l l a
    C: l’usuari haurà d’introduir un text, el valor que vol reemplaçar i el valor amb el que es vol reemplaçar.
    Exemple: 
    Entrada: Mira qui balla   | a | i        Sortida:  Miri qui billi 
    D:  l’usuari haurà d’introduir el nom d’un fitxer i el programa haurà d’indicar si el nom conté l’extensió de codi font de C# (“.cs”)
    E: Sortir (només ha d’escriure un missatge de comiat)

 */

using System;

namespace SegonaProvaPractica
{
    class SanchoJordiCodeEx5
    {
        static void Main()
        {
            const string MSGWelcome = "Benvingutd@! Escull Una opció:";
            const string MSGOptionA = "A: Busca una cadena en un text";
            const string MSGOptionB = "B: Monstrar totes les lletres d'un text separades per espais";
            const string MSGOptionC = "C: Substituir un caracter en un text per un altre caràcter";
            const string MSGOptionD = "D: Confirmar el nom d'un fitxer de codi font";
            const string MSGOptionE = "E: Sortir";
            const string MSGExit = "Has sortit del programa gracies per utilitzarlo";

            const string MSGInputText = "Introdueix el text: ";
            const string MSGSearchText = "Introdueix el text que vols buscar: ";
            const string MSGTextOK = "El text esta dins de la cadena";
            const string MSGTextKO = "El text no es dins la cadena";

            const string MSGInputTextOptionC = "Introdueix el text que vol que cambi les seves lletres i separats per  |  introduiexes el valor que vol reemplaçar i el valor amb el que es vol reemplaçar ";
            const string MSGTextCS = "Introdueix el nom del fitxer: ";
            const string MSGErrorInput = "Error, No has introduit un dels valors especificats torna a provar";
            string inputusertext, usertextsearch, textchangevalor="";
            char caseuser;
            bool respose = true;
            bool errorinput = false;
            while (respose)
            {
                if (errorinput)
                {
                    Console.WriteLine(MSGErrorInput);
                } else
                {
                    Console.WriteLine(MSGWelcome);
                    Console.WriteLine(MSGOptionA);
                    Console.WriteLine(MSGOptionB);
                    Console.WriteLine(MSGOptionC);
                    Console.WriteLine(MSGOptionD);
                    Console.WriteLine(MSGOptionE);
                }
                

                caseuser = Convert.ToChar(Console.ReadLine());

                switch (caseuser)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine(MSGInputText);
                        inputusertext = Console.ReadLine();
                        Console.WriteLine(MSGSearchText);
                        usertextsearch = Console.ReadLine();

                        Console.WriteLine(inputusertext.Contains(usertextsearch) ? MSGTextOK : MSGTextKO);
                        respose = false;
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine(MSGInputText);
                        inputusertext = Console.ReadLine();
                        foreach (var item in inputusertext)
                        {
                            if (item != ' ')
                            {
                                Console.Write(item + " ");
                            }
                        }
                        respose = false;
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine(MSGInputTextOptionC);
                        inputusertext = Console.ReadLine();
                        string[] texts = inputusertext.Split("|");
                        /* per treure espais */
                        foreach (var item in texts[1])
                        {
                            if (item != ' ')
                            {
                                texts[1] = Convert.ToString(item);
                            }
                        }
                        foreach (var item in texts[2])
                        {
                            if (item != ' ')
                            {
                                texts[2] = Convert.ToString(item);
                            }
                        }

                        foreach (var letter in texts[0])
                        {
                            if (letter == Convert.ToChar(texts[1]))
                            {
                                textchangevalor += Convert.ToChar(texts[2]);
                            }
                            else
                            {
                                textchangevalor += letter;
                            }
                        }
                        Console.WriteLine($"El text cambiat es {textchangevalor}");
                        respose = false;
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine(MSGTextCS);
                        inputusertext = Console.ReadLine();
                        Console.WriteLine(inputusertext.EndsWith(".cs") ? "Te l'extensio .cs" : "No te l'extensio .cs");
                        respose = false;
                        break;
                    case 'e':
                    case 'E':
                        Console.WriteLine(MSGExit);
                        respose = false;
                        break;
                }
                errorinput = true;
            }
        }
    }
}


