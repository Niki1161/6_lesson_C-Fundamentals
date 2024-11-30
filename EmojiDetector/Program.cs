namespace EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            long coolThreshold = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    coolThreshold *= input[i] - '0'; 
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
        }
    }
}