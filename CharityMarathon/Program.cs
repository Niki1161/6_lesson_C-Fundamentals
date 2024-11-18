using System;

internal class Program
{
    static void Main()
    {

        int marathonDays = int.Parse(Console.ReadLine());
        int totalRunners = int.Parse(Console.ReadLine());
        int averageLapsPerRunner = int.Parse(Console.ReadLine());
        int lapLengthMeters = int.Parse(Console.ReadLine());
        int trackCapacity = int.Parse(Console.ReadLine());
        double moneyPerKilometer = double.Parse(Console.ReadLine());


        int maxPossibleRunners = marathonDays * trackCapacity;

        int effectiveRunners = 0;

        if (totalRunners < maxPossibleRunners)
        {
            effectiveRunners = totalRunners;
        }
        else
        {
            effectiveRunners = maxPossibleRunners;
        }

        int totalMetersRun = effectiveRunners * averageLapsPerRunner * lapLengthMeters;

        double totalKilometersRun = totalMetersRun / 1000.0;

        double moneyRaised = totalKilometersRun * moneyPerKilometer;

        Console.WriteLine($"Money raised: {moneyRaised:f2}");
    }
}
