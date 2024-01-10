/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 11/10/2023
 * REPTE 11 OCTUBRE DNI Donat un DNI complet SENSE LLETRA (8 números), 
 * desenvolupa un programa que calculi quina lletra li pertoca. 
 * Investigueu quin és el patró que es fa servir al Ministeri d’Interior per 
 * aplicar-lo al vostre programa. Retorneu el DNI amb la lletra inclosa. 
 * Al acabar, pregunta si vol introduir un altre DNI o si vol sortir del programa.
 * 
 * Extra: Si el número introduït és un NIE (7 números), detecta-ho i retorna també 
 * el NIE amb la lletra corresponent. No es pot fer ús d’strings per fer els càlculs.
 *
 */

using System;
using System.Net;

namespace CalcDni
{
    public class CalcDni
    {
        public static void Main()
        {
            int respostuser, dniuser, numberlenght, calclenght;
            bool dniwhile=false, errordniornie = false, isdniornie;
            do
            {
                Console.WriteLine("Donem un DNI/NIE i et calculo la seva lletra: ");
                do
                {
                    numberlenght = 0;
                    if (errordniornie) { Console.WriteLine("EL numero que has introduit no es ni un DNI ni un NIE, torna a posarlo: "); }

                    calclenght = dniuser = Convert.ToInt32(Console.ReadLine());

                    while (calclenght > 0)
                    {
                        calclenght /= 10;
                        numberlenght++;
                    }
                    errordniornie = true;
                    isdniornie = numberlenght == 8 || numberlenght == 7 ? true : false;
                } while (!isdniornie);
                     
                bool dni = numberlenght == 8 ? true : false;

                switch (dniuser % 23)
                {
                    case 0:
                        if (dni)
                        {
                            Console.WriteLine(dniuser + "T");
                        } else
                        {
                            Console.WriteLine(dniuser + "X");
                        }
                        break;
                    case 1:
                        if (dni)
                        {
                            Console.WriteLine(dniuser + "R");
                        }
                        else
                        {
                            Console.WriteLine(dniuser + "Y");
                        }
                        break;
                    case 2:
                        if (dni)
                        {
                            Console.WriteLine(dniuser + "W");
                        }
                        else
                        {
                            Console.WriteLine(dniuser + "Z");
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine(dniuser + "A");
                        break;
                    case 4:
                        Console.WriteLine(dniuser + "G");
                        break;
                    case 5:
                        Console.WriteLine(dniuser + "M");
                        break;
                    case 6:
                        Console.WriteLine(dniuser + "Y");
                        break;
                    case 7:
                        Console.WriteLine(dniuser + "F");
                        break;
                    case 8:
                        Console.WriteLine(dniuser + "P");
                        break;
                    case 9:
                        Console.WriteLine(dniuser + "D");
                        break;
                    case 10:
                        Console.WriteLine(dniuser + "X");
                        break;
                    case 11:
                        Console.WriteLine(dniuser + "B");
                        break;
                    case 12:
                        Console.WriteLine(dniuser + "N");
                        break;
                    case 13:
                        Console.WriteLine(dniuser + "J");
                        break;
                    case 14:
                        Console.WriteLine(dniuser + "Z");
                        break;
                    case 15:
                        Console.WriteLine(dniuser + "S");
                        break;
                    case 16:
                        Console.WriteLine(dniuser + "Q");
                        break;
                    case 17:
                        Console.WriteLine(dniuser + "V");
                        break;
                    case 18:
                        Console.WriteLine(dniuser + "H");
                        break;
                    case 19:
                        Console.WriteLine(dniuser + "L");
                        break;
                    case 20:
                        Console.WriteLine(dniuser + "C");
                        break;
                    case 21:
                        Console.WriteLine(dniuser + "K");
                        break;
                    case 22:
                        Console.WriteLine(dniuser + "E");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine("Vols tornar a posar un altre DNI/NIE? Si = 1, No = 2 ");
                do
                {
                    respostuser = Convert.ToInt32(Console.ReadLine());
                    switch (respostuser)
                    {
                        case 1:
                            dniwhile = true;
                            break;
                        case 2:
                            dniwhile = false;
                            break;

                        default:

                            Console.WriteLine("Nombre introduit invalit tornal a posar: ");
                            break;
                    }

                } while (respostuser != 1 && respostuser != 2);

            } while (dniwhile);
        }
    }
}