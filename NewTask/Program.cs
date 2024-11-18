using System;

class Program
{
    static void Main()
    {
        // Read array
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Flip array
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }

        // Print array
        Console.WriteLine(string.Join(" ", array));
    }
}
