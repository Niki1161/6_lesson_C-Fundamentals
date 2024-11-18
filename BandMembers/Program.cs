using System;

class Program
{
    static void Main()
    {
        
        int membersCount = int.Parse(Console.ReadLine());

        double guitarPrice = double.Parse(Console.ReadLine());

        int guitarists = membersCount / 3;
        int vocalist = 1;

        int drummers = membersCount - guitarists - vocalist;

        double drumPrice = guitarPrice * 1.5; 

        double microphonePrice = (drummers * drumPrice) - (guitarists * guitarPrice);

        double totalGuitarCost = guitarists * guitarPrice;

        double totalDrumCost = drummers * drumPrice;

        double totalInstrumentCost = totalGuitarCost + totalDrumCost + microphonePrice;

        double monthlyRent = (totalGuitarCost + totalDrumCost + microphonePrice) / membersCount;

        double yearlyRent = monthlyRent * 12;

        double totalCost = totalInstrumentCost + yearlyRent;

        Console.WriteLine($"Total cost: {totalCost:F2}lv.");
    }
}
