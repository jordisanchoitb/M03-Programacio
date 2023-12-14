/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF1
 * v1. 13/12/2023
 * 18. Implementa un mètode que rebiun nombre enter (minuts) i retorni la seva conversió a segons.
 */

using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string MsgProgram = "Introdueix un nombre enter (minuts) i retornaré la seva conversió a segons: ";
            const string MsgConvert = "La conversió de {0} minuts a segons és: {1}";
            int inputuser;

            Console.Write(MsgProgram);
            inputuser = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(MsgConvert, inputuser, ConvertMinToSec(inputuser));
        }  

        public static int ConvertMinToSec(int minuts)
        {
            return minuts * 60;
        }
    }
}