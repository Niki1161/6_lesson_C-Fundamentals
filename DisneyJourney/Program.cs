namespace DisneyJourney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double totalSavedMoney = 0;
            double monthlySavedMoney = journeyCost * 0.25;

            for (int month = 1; month <= months; month++)
            {
                if (month % 2 == 1 && month != 1)
                {
                    totalSavedMoney -= totalSavedMoney * 0.16;
                }
               
                if (month % 4 == 0)
                {
                    var bonus = totalSavedMoney * 0.25;
                    totalSavedMoney += bonus;
                }

                totalSavedMoney += monthlySavedMoney;

            }

            if (totalSavedMoney > journeyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {totalSavedMoney - journeyCost:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {journeyCost - totalSavedMoney:f2}lv. more.");
            }


        }
    }
}