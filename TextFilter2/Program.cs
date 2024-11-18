namespace TextFilter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            for (int i = 0; i < banList.Length; i++)
            {
                string word = banList[i];
               
                string replacement = new string('*', word.Length);

                text = text.Replace(word, replacement);
            }

            Console.WriteLine(text);
        }
    }
}