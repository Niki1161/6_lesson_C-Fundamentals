using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^@#+([A-Z][a-zA-Z0-9]{4,}[A-Z])@#+$";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, regex);

                if (match.Success)  // valid barcode
                {
                    
                    string regexNums = @"[0-9]";

                    MatchCollection numberMatches = Regex.Matches(input, regexNums);

                    if (numberMatches.Count == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        string allNumbers = "";

                        foreach (Match item in numberMatches)
                        {
                            var num = item.Value;

                            allNumbers += num;                           
                        } 
                        Console.WriteLine($"Product group: {allNumbers}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}