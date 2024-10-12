using System.Net.Http.Headers;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end") 
            {
                string[] arguments = input.Split();
                int elements;

                switch (arguments[0])
                {
                    case "Insert":
                        int element = int.Parse(arguments[1]); 
                        int position = int.Parse(arguments[2]);
                        list.Insert(position, element);
                        break;
                    case "Delete":                        
                        int element = int.Parse(arguments[1]);
                        list.Remove(element);
                        break;

                }
            }
            
        }
    }
}