using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string place = Console.ReadLine();

            string regex = @"=[A-Z][a-z]{2,}=|[\\/][A-Z][a-z]{2,}[\/]";

            MatchCollection matches = Regex.Matches(place, regex);

            int counter = 0;

            Console.Write("Destinations: ");
            for (int i = 0; i < matches.Count; i++)
            {
                var match = matches[i];
                var destination = match.Value.Trim('=', '/');


                int lenght = destination.Length;

                counter += lenght;
                
                Console.Write(destination);
                if (i < matches.Count-1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Travel Points: {counter}");


        }
    }
}