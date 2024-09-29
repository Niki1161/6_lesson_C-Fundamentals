namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string[] arr1 = text1.Split();
            string text2 = Console.ReadLine();
            string[] arr2 = text2.Split();

            for (int i = 0; i < arr2.Length; i++)
            {
                string element = arr2[i];
               
                for (int j = 0; j < arr1.Length; j++)
                {
                    string cell = arr1[j];
                    if (cell == element)
                    {
                        Console.Write(cell + " ");
                        break;
                    }

                }
            }
        }
    }
}