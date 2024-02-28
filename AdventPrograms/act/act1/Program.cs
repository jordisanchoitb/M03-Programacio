using System;
using System.IO;

namespace AdventCode
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                string path = Path.GetFullPath(@"..\..\..\" + "input.txt");
                string[] sr = File.ReadAllLines(path);
                int sum = 0;

                for (int i = 0; i < sr.Length; i++)
                {
                    Console.Write("Linea " + i + " ");
                    string str = sr[i];
                    string numbers = "";
                    int index = 0;
                    bool found = false;
                    while (index < str.Length && !found)
                    {
                        if (IsNumber(str[index].ToString()))
                        {
                            numbers += str[index];
                            found = true;
                        }
                        index++;
                    }
                    index = str.Length;
                    found = false;
                    while (index > 0 && !found)
                    {
                        if (IsNumber(str[index - 1].ToString()))
                        {
                            numbers += str[index - 1];
                            found = true;
                        }
                        index--;
                    }
                    Console.WriteLine("Numero Concatenado: " + numbers);
                    sum += Convert.ToInt32(numbers);
                }

                Console.WriteLine("Sum: " + sum);
            } catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            

        }

        public static bool IsNumber(string number)
        {
            try
            {
                int num = Convert.ToInt32(number);
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
    }
}
