class Program
{
    static void Main()
    {

        decimal total = 0;
        decimal taxes = 0;

        decimal taxRate = 0.20m;
        decimal discount = 0.10m;

        string input;

        while ((input = Console.ReadLine()) != "special" && input != "regular")
        {
            decimal partPrice = decimal.Parse(input);

            if (partPrice <= 0)
            {
                Console.WriteLine("Invalid price!");
                continue;
            }

            total += partPrice;
        }

        if (total ==  0)
        {
            Console.WriteLine("Invalid price!");
        }
        else
        {
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {total:f2}$");
            Console.WriteLine($"Taxes{taxes:f2}$");
            Console.WriteLine("-----------");

            if (input == "special")
            {
                total -= (total + taxes) * discount;
            }

            Console.WriteLine($"Total price: {total}$");

        }
    }
}