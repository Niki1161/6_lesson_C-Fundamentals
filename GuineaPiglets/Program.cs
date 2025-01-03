﻿namespace GuineaPiglets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodQuantity = double.Parse(Console.ReadLine()) * 1000;
            double hayQuantity = double.Parse(Console.ReadLine()) * 1000;
            double coverQuantity = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;

            for (int day = 1; day <= 30; day++)
            {
                foodQuantity -= 300;

                if (day % 2 == 0)
                {
                    hayQuantity -= foodQuantity * 0.05;
                }

                if (day % 3 == 0)
                {
                    coverQuantity = coverQuantity - (weight / 3);
                }

                if (foodQuantity <= 0 || hayQuantity <= 0 || coverQuantity <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                else 
                {
                    
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodQuantity / 1000):f2}, Hay: {(hayQuantity / 1000):f2}, Cover: {(coverQuantity / 1000):f2}.");
        }
    }
}