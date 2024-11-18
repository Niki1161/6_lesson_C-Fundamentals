namespace ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string wordToReverse = Console.ReadLine();

                if (wordToReverse == "end")
                {
                    break;
                }

                string reversedWord  = string.Join("", wordToReverse.ToCharArray().Reverse());

                Console.WriteLine($"{wordToReverse} = {reversedWord}");
            }
        }
    }
}