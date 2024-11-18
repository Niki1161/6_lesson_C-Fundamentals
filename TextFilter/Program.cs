using System;

namespace TextFilter;

internal class Program
{
    static void Main(string[] args)
    {
        string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

        string text = Console.ReadLine();

        foreach (var bannedWord in bannedWords)
        {
            string replacedWithAsterisks = new string('*', bannedWord.Length);

            text = text.Replace(bannedWord, replacedWithAsterisks);
        }

        Console.WriteLine(text);
    }
}