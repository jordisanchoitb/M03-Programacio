/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 18/10/2023
 * Exercici 17.  Implementa un programa que demani a l’usuari quants valors vol emmagatzemar (en una llista). A continuació l’usuari els 
 * haurà d’introduir i el programa haurà de validar si és un nombre natural o no. 
 * En cas que no ho sigui, informarà a l’usuari i aquest disposarà de dos intents
 * més per a introduir el nombre correctament. Aquesta restricció és per a tots els
 * nombres que l’usuari introdueixi. En finalitzar, el programa haurà de retornar:

 *
 */

using System;

namespace Exercici17
{
    public class Exercici17
    {
        public static void Main()
        {
            const string MSGStartProgram = "Quants valor vols guardar?: ";
            const string MSGGetNumbers = "Introdueix unicament nombres naturals que vols que estiguin guardats: ";
            const string MSGErrorGetNumbers = "Error, introdueix unicament nombres naturals, torna a intentarlo: ";
            const string MSGTotalNumbers = "Total de nombres introduïts: ";
            const string MSGTotalNumberssmallto15 = "Total de nombres més petits de 15: ";
            const string MSGTotalNumbersbigto30 = "Total de nombres més grans de 30: ";
            const int fifteen = 15, thirty = 30;
            int lengtharray, tryssetnumber = 3, smalltoo15=0, bigtoo30=0, totalnumbers=;
            bool errorsetnumber = false;
            
            Console.WriteLine(MSGStartProgram);
            lengtharray = Convert.ToInt32(Console.ReadLine());
            int[] arraynumbers = new int[lengtharray];
            
            Console.WriteLine("");
            Console.WriteLine(MSGGetNumbers);
            for (int i = 0; i < lengtharray; i++)
            {
                int usernumber;
                tryssetnumber = 3;
                errorsetnumber = false;
                do 
                {
                    if (errorsetnumber)
                    {
                        Console.WriteLine(MSGErrorGetNumbers);
                    }
                    usernumber = Convert.ToInt32(Console.ReadLine());
                    errorsetnumber = true;
                    if (usernumber > 0)
                    {
                        arraynumbers[i] = usernumber;
                    }
                } while (usernumber <= 0 && tryssetnumber != 0);
                
                if (arraynumbers[i] > 0) 
                { 
                    if (arraynumbers[i] < fifteen) 
                    {
                        smalltoo15++;
                    }
                    if (arraynumbers[i] > thirty) 
                    { 
                        bigtoo30++;
                    }
                    totalnumbers++;
                }
            }

            Console.WriteLine(MSGTotalNumbers+totalnumbers);
            Console.WriteLine(MSGTotalNumberssmallto15+smalltoo15);
            Console.WriteLine(MSGTotalNumbersbigto30+bigtoo30);
        }
    }
}
