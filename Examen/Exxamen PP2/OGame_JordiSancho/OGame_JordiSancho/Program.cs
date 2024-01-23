using System;
using OGameMethods;

namespace OGame_JordiSancho
{
    class Program
    {
        static void Main()
        {
            Console.Write("SuccessRate:");
            Console.WriteLine(ExtractionLine.SuccessRate(10));
            Console.Write("ProductionRatePerHour:");
            Console.WriteLine(ExtractionLine.ProductionRatePerHour(6));
            Console.Write("WorkingItemsPerMinute:");
            Console.WriteLine(ExtractionLine.WorkingItemsPerMinute(6));
        }
    }
}