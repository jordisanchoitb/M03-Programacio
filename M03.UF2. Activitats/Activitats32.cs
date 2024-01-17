/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF2
 * v1. 19/12/2023
 * Exercici 32 En el mateix estudi, en paral·lel es porta a terme la creació del videojoc basat en Super 4, una sèrie d’animació basada en personatges de Playmobil. En aquesta primera part del projecte, el videojoc se centra en la fada Espurna. 
El jugador haurà d’escollir un dels següents avatars (suposem que es mostren les imatges següents i el jugador ha d’escollir entre [1,4]):
Un cop seleccionat l’avatar, el jugador haurà de posar-li un nom i indicar el seu nivell de maldat [1000, 50000]. Llavors l’Espurna haurà de llançar el seu encanteri contra l’avatar del jugador: si el nom assignat a l’avatar conté com a mínim dues vocals, l’Espurna podrà convertir la seva maldat en pols màgica per ajudar els seus companys, i la repartirà entre tot l’equip a parts iguals, deixant la resta com a maldat per a l’avatar. En cas contrari, només podrà repartir a parts iguals entre l’equip el 5% de la seva maldat, ja que l’encanteri no ho pot transformar-la tota.
Enumera els mètodes que hauràs d’implementar (només la declaració)
Implementa els UT per a aquests mètodes
Implementa el programa principal amb els mètodes corresponents
Assigna el projecte de UT a la solució i valida els mètodes
 */

using System;

namespace Program
{
    public static class Program
    {
        public static void Main()
        {
            const string MsgSelectAvatar = "Selecciona un avatar [1,4]: ";
            const string MsgSelectAvatarError = "Error, el valor ha d'estar entre 1 i 4";
            const string MsgNameAvatar = "Introdueix el nom de l'avatar: ";
            const string MsgNameAvatarError = "El nom de l'avatar ha de tenir entre 2 i 25 caràcters i no pot contenir caràcters especials";
            const string MsgEvilLevel = "Introdueix el nivell de maldat [1000, 50000]: ";
            const string MsgEvilLevelError = "El nivell de maldat ha d'estar entre 1000 i 50000";

            int selectedAvatar, evilLevel, poweredPrs1=0, poweredPrs2=0, poweredPrs3=0, poweredPrs4=0;
            string nameAvatar;
            bool error = false;

            do
            {

                if (error)
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgSelectAvatarError);
                }
                Console.Write(MsgSelectAvatar);
                selectedAvatar = Convert.ToInt32(Console.ReadLine());
            } while (!CheckNumAvatar(selectedAvatar));

            error = false;
            Console.WriteLine(MsgNameAvatar);
            do
            {
                if (error)
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgNameAvatarError);
                }
                nameAvatar = Console.ReadLine() ?? "";
            } while (!CheckLenghtName(nameAvatar) && CheckNotCharactersSpecial(nameAvatar));

            error = false;
            Console.WriteLine(MsgEvilLevel);
            do
            {
                if (error)
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgEvilLevelError);
                }
                evilLevel = Convert.ToInt32(Console.ReadLine());
            } while (!CheckEvilLevel(evilLevel));

            Console.WriteLine();
            if (ContainsTwoVowels(nameAvatar))
            {
                Console.WriteLine("L'Espurna ha convertit la maldat en pols màgica i l'ha repartit entre tot l'equip");
                ReparEvilLevel(evilLevel, ref poweredPrs1, ref poweredPrs2, ref poweredPrs3, ref poweredPrs4, ContainsTwoVowels(nameAvatar));
            }
            else
            {
                Console.WriteLine("L'Espurna només ha pogut repartir el 5% de la maldat entre tot l'equip");
                ReparEvilLevel(evilLevel, ref poweredPrs1, ref poweredPrs2, ref poweredPrs3, ref poweredPrs4, ContainsTwoVowels(nameAvatar));
            }



        }
        public static bool CheckNumAvatar(int num) 
        {
            return num >= 1 && num <= 4;
        }

        public static bool CheckLenghtName(string name)
        {
            return name.Length >= 2 && name.Length <= 25;
        }

        public static bool CheckNotCharactersSpecial(string name)
        {
            char[] CaracteresEspeciales = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '=', '-', '/', '\\', '|', '<', '>', ',', '.', '?', ';', ':', '[', ']', '{', '}', '"' };
                
            foreach (char caracter in CaracteresEspeciales)
            {
                if (name.Contains(caracter))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckEvilLevel(int level)
        {
            return level >= 1000 && level <= 50000;
        }

        public static bool ContainsTwoVowels(string name)
        {
            int count = 0;
            foreach (char c in name)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c =='u')
                {
                    count++;
                }
            }
            return count >= 2;
        }

        public static void ReparEvilLevel(int level, ref int prs1, ref int prs2, ref int prs3, ref int prs4, bool containsTwoVowels)
        {
            if (containsTwoVowels)
            {
                prs1 = level / 4;
                prs2 = level / 4;
                prs3 = level / 4;
                prs4 = level / 4;
            }
            else
            {
                prs1 = level / 20;
                prs2 = level / 20;
                prs3 = level / 20;
                prs4 = level / 20;
            }

            Console.WriteLine("El nivell de maldat de l'avatar 1 és: {0}", prs1);
            Console.WriteLine("El nivell de maldat de l'avatar 2 és: {0}", prs2);
            Console.WriteLine("El nivell de maldat de l'avatar 3 és: {0}", prs3);
            Console.WriteLine("El nivell de maldat de l'avatar 4 és: {0}", prs4);

        }
    }
}