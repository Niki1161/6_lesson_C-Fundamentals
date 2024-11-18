using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the initial list of integers from the console
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }                

            string[] Parts = command.Split();

            string action = Parts[0];

            if (action == "Delete")
            {
                int elementToDelete = int.Parse(Parts[1]);
                numbers.RemoveAll(n => n == elementToDelete);
            }
            else if (action == "Insert")
            {
                int elementToInsert = int.Parse(Parts[1]);
                int position = int.Parse(Parts[2]);
                if (position >= 0 && position <= numbers.Count)
                {
                    numbers.Insert(position, elementToInsert);
                }
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
