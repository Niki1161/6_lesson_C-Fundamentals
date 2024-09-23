using System;

class Program
{
    static void Main()
    {
        int countt = int.Parse(Console.ReadLine());

        string biggestModel = "";
        double biggestVolume = 0;

        for (int i = 0; i < countt; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;

            if (volume > biggestVolume)
            {
                biggestVolume = volume;
                biggestModel = model;
            }
        }

        Console.WriteLine(biggestModel);
    }
}
