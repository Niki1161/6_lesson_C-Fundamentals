using System;
using System.Collections.Generic;
using System.Linq;


namespace EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbersStr = Console.ReadLine();
            string[] numbersArrStr = numbersStr.Split();
            int[] numbers = numbersArrStr.Select(int.Parse);                 
        }
    }
}