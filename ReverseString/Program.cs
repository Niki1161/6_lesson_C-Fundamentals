using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(ReverseString(input));
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
