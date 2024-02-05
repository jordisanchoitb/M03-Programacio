/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 19/12/2023
 * 
 * Exercici 1. Crea un projecte nou i implementa la definició de la classe Persona, així com la seva instanciació.
 */

using System;
using activitats;

namespace Program
{
    public static class Program
    {
        public static void Main()
        {

            Persona persona = new Persona("Jordi", "Sancho", 21, "12345678A", 1.80, 80);

            persona.PrintAllInfoPerson();
                        
        }
    }
}