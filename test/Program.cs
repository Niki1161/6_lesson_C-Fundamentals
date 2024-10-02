namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string elements = "apple banana orange";
            //string[] fruits = elements.Split();
            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i] + " ");
            //}


            //string[] vegitables = new string[] { "pumpkin", "tomato", "eggplant", "cucumber" };

            //for (int i = 0; i < vegitables.Length; i++)
            //{
            //    Console.WriteLine(vegitables[i] + " ");
            //}


            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string result = "no";

            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int left = 0; left < i; left++)  // leftSum
                {
                    leftSum += nums[left];
                }

                for (int right = i + 1; right < nums.Length; right++)  // rightSum
                {
                    rightSum += nums[right];
                }

                if (leftSum == rightSum)
                {
                    result = i.ToString();
                }

            }

            Console.WriteLine(result);

        }
    }
}