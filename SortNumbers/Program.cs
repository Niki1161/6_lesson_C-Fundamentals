namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            if (num1 > num2)
            {
                max1 = num1;
                max2 = num2;
            }
            else
            {
                max1 = num2;
                max2 = num1;
            }

            if (num3 > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = num3;
            }
            else if (num3 > max2)
            {
                max3 = max2;
                max2 = num3;
            }
            else
            {
                max3 = num3;
            }

            Console.WriteLine(max1);
            Console.WriteLine(max2);
            Console.WriteLine(max3);


        }
    }
}