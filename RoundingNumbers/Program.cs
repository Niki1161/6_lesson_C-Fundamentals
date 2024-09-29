using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = Console.ReadLine()
                                  .Split(' ')
                                  .Select(double.Parse)
                                  .ToArray();

        foreach (double number in numbers)
        {
            int roundedNumber = (int)Math.Round(number, MidpointRounding.AwayFromZero);

            Console.WriteLine($"{number} => {roundedNumber}");
        }
    }
}
