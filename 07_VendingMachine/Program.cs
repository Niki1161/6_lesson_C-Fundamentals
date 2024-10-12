using System;

namespace _07_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            string command;

            while ((command = Console.ReadLine()) != "Start")
            {
                double coin = double.Parse(command);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    balance += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            double nutsPrice = 2;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Nuts" && balance >= nutsPrice)
                {
                    balance -= nutsPrice;
                    Console.WriteLine("Purchased nuts");
                }
                else if (command == "Water" && balance >= waterPrice)
                {
                    balance -= waterPrice;
                    Console.WriteLine("Purchased water");
                }
                else if (command == "Crisps" && balance >= crispsPrice)
                {
                    balance -= crispsPrice;
                    Console.WriteLine("Purchased crisps");
                }
                else if (command == "Soda" && balance >= sodaPrice)
                {
                    balance -= sodaPrice;
                    Console.WriteLine("Purchased soda");
                }
                else if (command == "Coke" && balance >= cokePrice)
                {
                    balance -= cokePrice;
                    Console.WriteLine("Purchased coke");
                }
                else if (command == "Nuts" || command == "Water" || command == "Crisps" || command == "Soda" || command == "Coke")
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {balance:F2}");
        }
    }
}
