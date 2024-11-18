namespace SortNumbers2017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.Sort();

            string output = string.Join(" <= ", input);

            Console.WriteLine(output);
        }
    }
}