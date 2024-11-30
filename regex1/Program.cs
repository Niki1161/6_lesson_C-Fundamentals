using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace regex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string name = Console.ReadLine();

            MatchCollection matches = Regex.Matches(name, regex);
            
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine(matches);
        }
    }
}