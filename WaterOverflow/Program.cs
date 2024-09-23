using System.Reflection.Metadata.Ecma335;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int capacity = 255;
            int quantity = 0;

            for (int i = 0; i < times; i++)
            {                
                int liters = int.Parse(Console.ReadLine());

                if (quantity + liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    quantity += liters;
                }
               
            }

            Console.WriteLine(quantity);

        }
    }
}