using System.Runtime.CompilerServices;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] array = numbers.Split(" ");

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++) // rotation
            {
                string temp = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = temp;
            }

            for (int i = 0; i < array.Length; i++)   // Print  array
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}