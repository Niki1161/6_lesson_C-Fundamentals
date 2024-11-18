using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] parts = input.Split();  // 'Add 3'   =>  [Add][3]

            int num1 = int.Parse(parts[1]);

            if (parts[0] == "Add")
            {
                int numberToAdd = int.Parse(parts[1]);
                numbers.Add(numberToAdd);
            }
            if (parts[0] == "Remove")
            {
                int numberToRemove = int.Parse(parts[1]);
                numbers.Remove(numberToRemove);
            }
            if (parts[0] == "RemoveAt")
            {
                int numberToRemoveAt = int.Parse(parts[1]);
                numbers.RemoveAt(numberToRemoveAt);
            }
            if (parts[0] == "Insert")
            {
                int numberToInsert = int.Parse(parts[1]);
                int indexToInsert = int.Parse(parts[2]);
                numbers.Insert(indexToInsert, numberToInsert);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));

    }
}
