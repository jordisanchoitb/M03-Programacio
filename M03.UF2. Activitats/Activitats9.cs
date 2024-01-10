/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 21/11/2023
 * 9. Implementa un mètode per a utilitzar en un programa
 * principal, o invocat per un altre mètode, que permeti 
 * validar si un nombre és més petit que un valor 
 * (introduït per teclat) o és dins d’un rang 
 * (està dins de dos valors introduïts per teclat). 
 * Els missatges que es mostraran han de poder ser parametritzables.  
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            int usernumber, valornumber, firstrangnumber, secondrangnumber;
            string userinput;
            Console.WriteLine("Donem un numero");
            usernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que vols fer?\nValidar que el nombre introduit es mes petit que un altre (petit)?\nValidar si el nombre introduit esta dins del rang de dos valors (rang)?");
            userinput = Console.ReadLine();
            if (userinput.ToLower() == "petit")
            {
                Console.WriteLine("Donem el numero per comprovar si el valor introduit al principi es mes gran o mes petit que aquest:");
                valornumber = Convert.ToInt32(Console.ReadLine());
                NumberLess(usernumber, valornumber);
            } else if (userinput.ToLower() == "rang")
            {
                Console.WriteLine("Donem el primer numero del rang");
                firstrangnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Donem el segon numero del rang");
                secondrangnumber = Convert.ToInt32(Console.ReadLine());
                NumberLess(usernumber, firstrangnumber, secondrangnumber);
            } else
            {
                Console.WriteLine("Error, el text introduit no es el especificat");
            }

        }
        public static void NumberLess(int number, int valornumber)
        {
            Console.WriteLine(number < valornumber ? "El primer numero intrudiut es menor que el segon numero intrudiut" : "El primer numero intrudiut es major que el segon numero intrudiut");
        }
        public static void NumberLess(int usernumber, int firstnumberrang, int secondnumberrang)
        {
            if (firstnumberrang > secondnumberrang)
            {
                int aux = firstnumberrang;
                firstnumberrang = secondnumberrang;
                secondnumberrang = aux;
            }
            Console.WriteLine(usernumber > firstnumberrang && usernumber < secondnumberrang ? "El primer nombre introduit esta dins del rang d'entre el segon i el tercer nombre introduit" : "El primer nombre introduit no esta dins del rang d'entre el segon i el tercer nombre introduit");
        }
    }
}