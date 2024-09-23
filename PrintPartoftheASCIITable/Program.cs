using System;

class ASCIITable
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for (int symbol = start; symbol <= end; symbol++)
        {
            Console.Write((char)symbol + " ");
        }
    }
}
