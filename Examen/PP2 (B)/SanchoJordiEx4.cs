/* 
    Autor: Jordi Sancho
    Data: 15/11/2023
    4. El següent tipus de dades emmagatzema les notes mitjanes d’un grup de cicles formatius.
    Cada nota correspon a la nota mitjana de cada alumne:

 */

using System;

namespace SegonaProvaPractica
{
    class SanchoJordiCodeEx4
    {
        static void Main()
        {
            float[] marks = { 5.5f, 10f, 3.5f, 1.25f, 1.75f, 6.2f, 5.15f, 6.75f, 4.15f, 9.25f, 8.75f, 2.75f, 0.0f, 1.35f, 6.55f };
            const string MSGMedian = "La nota mtijana de la classe és: ";
            float median;
            int nota;

            /* Apartat A */
            median = 0;
            nota = 0;
            foreach (var mark in marks)
            {
                nota++;
                Console.WriteLine($"Nota {nota}: {mark}");
                median += mark;
            }
            Console.WriteLine($"{MSGMedian}{median/marks.Length}");
            Console.WriteLine();
            Console.WriteLine();

            /* Apartat B */
            median = 0;
            nota = 0;
            for ( int i = 0; i < marks.Length - 1; i++ )
            {
                for ( int j = i + 1; j < marks.Length; j++ )
                {
                    if (marks[i] < marks[j])
                    {
                        float aux = marks[i];
                        marks[i] = marks[j];
                        marks[j] = aux;
                    }
                }
            }

            foreach (var mark in marks)
            {
                nota++;
                Console.WriteLine($"Nota {nota}: {mark}");
                median += mark;
            }
            Console.WriteLine($"{MSGMedian}{median / marks.Length}");
            Console.WriteLine();
            Console.WriteLine();

            /* Apartat C */
            int alumncount;
            const string MSGAlumnCount = "Hi ha {0} alumnes que han obtingut notes entre 4 i 9 de mitjana (inclosos)";
            median = 0;
            nota = 0;
            alumncount = 0;
            foreach (var mark in marks)
            {
                nota++;
                Console.WriteLine($"Nota {nota}: {mark}");
                median += mark;
                if (mark >= 4 &&  mark <= 9)
                {
                    alumncount++;
                }
            }
            Console.WriteLine($"{MSGMedian}{median / marks.Length}");
            Console.WriteLine(MSGAlumnCount, alumncount);
            Console.WriteLine();
            Console.WriteLine();

            /* Apartat D */
            const string MSGGetInput = "Donem un numero i et dic si esta dins la llista o no esta";
            const string MSGOK = "El numero introduit esta dins la llista";
            const string MSGKO = "El numero introduit no esta dins la llista";
            
            bool found = false;
            int numlist; 
            double userinput;

            Console.WriteLine(MSGGetInput);
            userinput = Convert.ToDouble(Console.ReadLine());  
            numlist = 0;
            while (numlist < marks.Length && !(found))
            {
                if (userinput == marks[numlist])
                {
                    found = true;
                }
                numlist++;
            }
            Console.WriteLine(found ? MSGOK : MSGKO);


        }
    }
}




