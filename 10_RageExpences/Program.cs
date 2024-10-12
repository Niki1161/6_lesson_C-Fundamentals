using System;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashes = lostGamesCount / 2;
            int mouseTrashes = lostGamesCount / 3;
            int keyboardTrashes = lostGamesCount / 6; 
            int displayTrashes = keyboardTrashes / 2; 

            
            double totalExpenses = (headsetTrashes * headsetPrice) +
                                   (mouseTrashes * mousePrice) +
                                   (keyboardTrashes * keyboardPrice) +
                                   (displayTrashes * displayPrice);
                        
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
