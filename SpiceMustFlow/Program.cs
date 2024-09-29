using System;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int extractedSpices = 0;
            int days = 0;

            const int minimalYield = 100;
            const int yieldDrop = 10;
            const int crewConsumption = 26;

            while (yield >= minimalYield)
            {
                extractedSpices += yield;  
                days++;  
                extractedSpices -= crewConsumption;  
                yield -= yieldDrop;  
            }

            if (extractedSpices >= crewConsumption)
            {
                extractedSpices -= crewConsumption;
            }

            Console.WriteLine(days);
            Console.WriteLine(extractedSpices);
        }
    }
}
