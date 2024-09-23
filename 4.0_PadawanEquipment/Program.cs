namespace _4._0_PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine()); 
            double priceLightSaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int freeBelts = 0;
            double extraSabers = Math.Ceiling(studentsCount * 0.1);

            double priceForOneStudent = priceLightSaber + priceRobe + beltPrice;

            if (studentsCount > 6)
            {
                freeBelts += studentsCount / 6;
            }

            double totalPrice = (priceForOneStudent * studentsCount) - freeBelts * beltPrice + (extraSabers * priceLightSaber);

            if (totalPrice > money)
            {
                Console.WriteLine($"John will need {totalPrice - money:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}