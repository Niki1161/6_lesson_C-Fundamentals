using System;

namespace MidExamProblem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double singelEggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int freeFlourPackages = studentsCount / 5;

            int neededFlourPackages = studentsCount - freeFlourPackages;
                       
            double apronsNeeded = Math.Ceiling(studentsCount * 1.2);

            double totalApronCost = apronsNeeded * apronPrice;

            double totalEggCost = studentsCount * 10 * singelEggPrice;

            double totalFlourCost = neededFlourPackages * flourPrice;

            double totalCost = totalApronCost + totalEggCost + totalFlourCost;


            double neededMoney = totalCost - budget;

            if (totalCost <= budget)
            {
                Console.WriteLine($"Items purchased for {totalCost:f2}$.");
            }
            else
            {                
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
        }
    }
}
