namespace PassedOrFailed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number < 3.00)
            {
                Console.WriteLine("Failed!");
            }
            else
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}