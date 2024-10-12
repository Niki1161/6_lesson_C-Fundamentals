namespace IntegerLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new () {1, 2, 3, 4};

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}