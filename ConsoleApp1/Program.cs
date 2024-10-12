namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] daysOfWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Saturday",
                "Friday",
                "Saturday",
                "Sunday",

            };

            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(daysOfWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}