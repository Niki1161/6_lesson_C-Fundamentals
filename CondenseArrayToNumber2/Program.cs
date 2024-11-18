namespace CondenseArrayToNumber2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            while (numbers.Length > 1)
            {
                int[] condensedArray = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensedArray[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensedArray;
            }

            Console.WriteLine(numbers[0]);
        }

        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int limit = numberArray.Length - 1;

            for (int index = 0; index < numberArray.Length; index++)
            {                
                for (int i = 0; i < limit; i++)
                {
                    numberArray[i] = numberArray[i] + numberArray[i + 1];
                }

                limit = limit - 1;
            }

            Console.WriteLine(numberArray[0]);
        }
    }
}