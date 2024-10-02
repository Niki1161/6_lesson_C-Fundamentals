using System;

namespace TopIntegers
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split();

            int[] integers = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int num = int.Parse(array[i]);
                integers[i] = num;
            }
            //-------------------

            int max = int.MinValue;

            for (int j = 0; j < integers.Length; j++)
            {
                var current = integers[j];

                bool forprint = true;

                for (int k = j; k < integers.Length; k++)
                {
                    if (current < integers[k])
                    {
                        forprint = false;
                        break;
                    }
                }
                if (forprint)
                {
                    Console.Write(current + " ");
                }
                
            }

            //Console.WriteLine(max);
            //Console.WriteLine($"index:{maxIndex}");
        }
    }
}