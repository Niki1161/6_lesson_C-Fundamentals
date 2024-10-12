using System.Collections.Immutable;

namespace SortNumbers_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());

            //int[] numbers = new int[] {num1, num2, num3};

            //Array.Sort(numbers);

            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[0]);
            
            List<int> list = new List<int>() {  };
            int capacity = list.Capacity;
            int count = list.Count;
            int countMethod = list.Count();

            list.Add(1);
            list.Add(2);

            capacity = list.Capacity;

            list.Add(5);
            list.Add(5);

            capacity = list.Capacity;
            count = list.Count;

            list.Add(1);

            int newCapacity = list.Capacity;
        }
    }
}