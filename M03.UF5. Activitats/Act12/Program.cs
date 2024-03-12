/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 
 * 
 * 
*/
namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 2,5,6,8,1,74,5,7,3,4,543,345,675,34,23,12 };
           

            numbers.RemoveAll(x => x > 10);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            

        }
    }
}
