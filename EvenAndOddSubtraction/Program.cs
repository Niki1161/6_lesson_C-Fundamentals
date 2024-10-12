namespace EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int even = 0;
            int odd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    even += currentNumber;
                }
                else
                {
                    odd += currentNumber;
                }
                                
            }
            int difference = even - odd;
            Console.WriteLine(difference);

        }
    }
}