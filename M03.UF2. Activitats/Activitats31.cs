/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * Exercici 31. En l’estudi on estàs fent les pràctiques, volen llençar un nou videojoc. Les tasques que t’han assignat són crear les rutines següents que s’afegiran al programa que està implementant tot l’equip:
Demanar a l’usuari el nom del personatge amb el que vol jugar. La rutina ha de validar que el nom no superi els 10 caràcters.
Demanar a l’usuari que introdueixi un nombre dins del rang [1,500].
Generar un valor aleatori (posició del mapa) entre el 1 i el 100.

 */

using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string MsgName = "Introdueix el nom del personatge: ";
            const string MsgNameError = "El nom no pot superar els 10 caràcters.";
            const string MsgNumber = "Introdueix un nombre entre 1 i 500: ";
            const string MsgNumberError = "El nombre ha d'estar entre 1 i 500.";
            const string MsgRandom = "La posicio en el mapa es: ";
            string name;
            bool validName = false;
            Console.Write(MsgName);
            do
            {
                if (validName)
                {
                    Console.WriteLine(MsgNameError);
                }
                name = Console.ReadLine() ?? "Patata";
                validName = true;
            } while (!CheckName(name));

            int number;
            bool validNumber = false;
            Console.Write(MsgNumber);
            do
            {
                if (validNumber)
                {
                    Console.WriteLine(MsgNumberError);
                }
                number = Convert.ToInt32(Console.ReadLine());
                validNumber = true;
            } while (!CheckNumber(number));

            Console.WriteLine(MsgRandom + PositionMap());
            
        }


        public static bool CheckName(string name)
        {
            if (name.Length > 10)
            {
                return false;
            }
            return true;
        }

        public static bool CheckNumber(int number)
        {
            if (number < 1 || number > 500)
            {
                return false;
            }
            return true;
        }

        public static int PositionMap()
        {
            Random random = new Random();
            return random.Next(2, 100);
        }
    }
}