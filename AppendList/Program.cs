namespace AppendList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input = 1 2 3 | 4 5 6 |  7  8         input.Count = 3
            // output = 7 8 4 5 6 1 2 3

            List<string> input = Console.ReadLine().Split("|").Select(x => x.Trim()).ToList();
                        
            for (int i = input.Count-1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            List<int> result = new List<int>();
        }
    }
}