/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 24. Fent servir la interpolació, implementa un programa en el que es demani a l’usuari el seu nom, cognoms i edat i retorni un missatge informatiu, com a l’exemple:
 *
 */

namespace Exercici24
{
    public class Exercici24
    {
        public static void Main()
        {
            const string MSGName = "Donem el teu nom: ";
            const string MSGSurname = "Donem el teu cognom: ";
            const string MSGAge = "Donem la teva edat: ";
            string name, surname, age;


            Console.WriteLine(MSGName);
            name = Console.ReadLine();
            Console.WriteLine(MSGSurname);
            surname = Console.ReadLine();
            Console.WriteLine(MSGAge);
            age = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"{name} {surname} té {age} anys");
        }
    }
}

