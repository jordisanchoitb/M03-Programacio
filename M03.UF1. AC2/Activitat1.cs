/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 1.  Modifica’l de manera que el missatge de validació per a l’usuari sigui diferent en cas que sigui la primera vegada que fa la petició o si ja hi ha hagut un error.
 *
 */
using System;
namespace DataTypes
{
    class MyDataTypes
    {
        static void Main()
        {
            const string MsgFirstNum = "Introdueix un nombre natural";
            const string MsgSecondNum = "Introdueix un segon nombre natural";
            const string MsgErrorFirstNum = "Error el número ha de ser més gran que 0, Introdueix un altre nombre natural";
            const string MsgErrorSecondNum = "Error el numero ha de ser més gran que 0, Introdueix un altre nombre natural";
            const string MsgOK = "El primer valor és múltiple del segon valor";
            const string MsgKO = "El primer valor no és múltiple del segon valor";
            const string MsgExit = "Pulsa qualsevol tecla per sortir";

            int firstNum, secondNum;
            bool errorfirstnum=true, errorsecondnum=true;
            do 
            {
                Console.WriteLine(errorfirstnum ? MsgFirstNum : MsgErrorFirstNum);
                errorfirstnum=false;
                firstNum = Convert.ToInt16(Console.ReadLine());
            } while (firstNum < 1);

            do
            {
                Console.WriteLine(errorsecondnum ? MsgSecondNum : MsgErrorSecondNum);
                errorsecondnum=false;
                secondNum = Convert.ToInt16(Console.ReadLine());
            } while (secondNum < 1);

            Console.WriteLine(firstNum % secondNum == 0 ? MsgOK : MsgKO);
            Console.WriteLine(MsgExit);
            Console.ReadKey();
        }
    }
}
