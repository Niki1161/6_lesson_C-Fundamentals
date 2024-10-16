namespace CompStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<decimal> prices = new List<decimal>();

            decimal tax = 0.2m;

            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");                  
                }
                else
                {
                    prices.Add(price);
                }

                input = Console.ReadLine();                
            }

            var total = prices.Sum();
            var taxAmount = total * tax;
            var priceWithTax = total + (taxAmount);

            if (priceWithTax == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if (input == "special")
            {
                priceWithTax -= priceWithTax * 0.10m;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {total:f2}$");
            Console.WriteLine($"Taxes: {taxAmount:f2}$");
            Console.WriteLine("-----------");

            Console.WriteLine($"Total price: {priceWithTax:f2}$");
        }
    }
}