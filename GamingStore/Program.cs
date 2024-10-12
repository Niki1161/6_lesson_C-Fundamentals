using System;

namespace GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;

            double OutFall4 = 39.99;
            double csog = 15.99;
            double ZplinterZell = 19.99;
            double HonoredTwo = 59.99;
            double RoverWatch = 29.99;
            double RoverWatchOriginsEdition = 39.99;

            string input;

            while ((input = Console.ReadLine()) != "Game Time")
            {
                double price = 0;

                if (input == "OutFall 4")
                {
                    price = OutFall4;
                }
                else if (input == "CS: OG")
                {
                    price = csog;
                }
                else if (input == "Zplinter Zell")
                {
                    price = ZplinterZell;
                }
                else if (input == "Honored 2")
                {
                    price = HonoredTwo;
                }
                else if (input == "RoverWatch")
                {
                    price = RoverWatch;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    price = RoverWatchOriginsEdition;
                }
                else
                {
                    
                    Console.WriteLine("Not Found");
                    continue;
                }

               
        }   }
    }
}