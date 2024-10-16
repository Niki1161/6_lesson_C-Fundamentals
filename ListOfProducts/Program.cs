namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < numberN; i++)
            {
                string currentProduct = Console.ReadLine();
                names.Add(currentProduct);
            }
            names.Sort();

            for (int i = 0;i < numberN; i++)
            {
                Console.WriteLine($"{i+1}.{names[i]}");
            }
            
        }
    }
}