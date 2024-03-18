/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 18/3/2024
 * 
 * Kata Code
 */
using System;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(LogLine.Message("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.Message("[WARNING]:  Disk almost full\r\n"));
            Console.WriteLine(LogLine.Message("[INFO]: Operation completed"));
            Console.WriteLine();
            Console.WriteLine(LogLine.LogLevel("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.LogLevel("[WARNING]:  Disk almost full\r\n"));
            Console.WriteLine(LogLine.LogLevel("[INFO]: Operation completed"));
            Console.WriteLine();
            Console.WriteLine(LogLine.Reformat("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.Reformat("[WARNING]:  Disk almost full\r\n"));
            Console.WriteLine(LogLine.Reformat("[INFO]: Operation completed"));
        }
    }

    public static class LogLine
    {
        public static string Message(string message)
        {
            string[] strings = message.Split(' ');
            string msg = "";
            for (int i = 1; i < strings.Length; i++)
            {
                msg += strings[i].Trim() + " ";
            }
            return msg.Trim();
        }

        public static string LogLevel(string message)
        {
            string[] strings = message.Split(' ');
            string level = strings[0];
            return level.Substring(1, level.Length - 3).ToLower();
        }

        public static string Reformat(string message)
        {
            return $"{Message(message)} ({LogLevel(message)})";
        }
    }
}
