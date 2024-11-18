namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                decimal orderPrice = (daysInMonth * capsulesCount) * pricePerCapsule;
                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}