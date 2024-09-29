namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagoonCount = int.Parse(Console.ReadLine());
            int[] train = new int[wagoonCount];
            int sum = 0;

            for (int i = 0; i < wagoonCount; i++)
            {
                int passangers = int.Parse(Console.ReadLine());
                train[i] = passangers;
                sum += passangers;
            }

            for (int i = 0; i < wagoonCount; i++)
            {
                Console.Write(train[i] + " ");                
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}