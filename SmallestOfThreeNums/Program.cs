namespace SmallestOfThreeNums
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = FindSmallest(num1, num2, num3);

            Console.WriteLine(result);
        }


        static int FindSmallest(int num1, int num2, int num3) 
        {
            int smallest = int.MaxValue;

            if (num1 < smallest)
            {
                smallest = num1;
            }
            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }

            return smallest;
        }

    }
}