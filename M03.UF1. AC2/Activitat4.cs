/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 4.   A partir de la següent especificació de l’algorisme representada 
 * (mitjançant el diagrama de flux de l’esquerra), implementa una solució en C#. 
 * Un cop implementada, executa un joc de proves (amb diferents valors) amb el debugger i 
 * explica com funciona en un breu vídeo. Adjunta la url del vídeo que has gravat
 *
 */

using System;

namespace diagramflux
{
    public class diagramflux
    {
        public static void Main()
        {
            int num;
            const string MSGprogram = "Donem un numero enter i et retorno el numero restant cada vegada 3 al numero donat fins que sigui mes petit que 0: ";
            
            Console.WriteLine(MSGprogram);
            num = Convert.ToInt32(Console.ReadLine());


            for (int i = num; i > 0; i-=3) 
            {
                Console.WriteLine(i);
            }
        }
    }
}


