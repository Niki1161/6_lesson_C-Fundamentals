namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            // hi abc add
            foreach (string currentWord in words)
            {
                for (int j = 0; j < currentWord.Length; j++)
                {
                    Console.Write(currentWord);
                }
            }
        }
    }
}