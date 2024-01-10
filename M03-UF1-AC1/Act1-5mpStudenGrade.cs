using System;

namespace mpStudenGrade
{
    public class mpStudenGrade
    {
        public static void Main()
        {
            int approved, notApproved, grades, gradesApproved, gradesNotApproved, averageApproved, averageNotAproved;
            bool whileverif;
            Console.WriteLine("Donem les 8 notes del alumne i et dono quantes ha aprovat, quants ha suspes i la nota mitja dels dos: ");
            approved = 0;
            notApproved = 0;
            gradesApproved = 0;
            gradesNotApproved = 0;
            averageApproved = 0;
            averageNotAproved = 0;

            for (int i = 0; i < 8; i++)
            {
                whileverif = true;
                do
                {
                    grades = Convert.ToInt32(Console.ReadLine());
                    if (grades >= 0)
                    {
                        if (grades >= 5)
                        {
                            gradesApproved += grades;
                            approved++;
                        } else
                        {
                            gradesNotApproved += grades;
                            notApproved++;
                        }
                        whileverif=false;
                    } else
                    {
                        Console.WriteLine("Has introduit un nombre que no es natural torna a posar el numero: ");
                    }
                } while (whileverif);
            }
            if (approved != 0) 
            {
                averageApproved = gradesApproved / approved;
            }
            if (notApproved != 0)
            {
                averageNotAproved = gradesNotApproved / notApproved;
            }
            Console.WriteLine("Las MP aprovades son: " + approved + " i les no aprovades son: " + notApproved + ", la mitjana de les MP aprovades es: " + averageApproved + " i les no aprovades son: " + averageNotAproved);
        }
    }
}