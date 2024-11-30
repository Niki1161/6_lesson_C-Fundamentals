using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (!command.Contains("Reveal"))
            {
                List<string> commandParts = new List<string>(command.Split(":|:"));

                string operation = commandParts[0];

                if (operation == "ChangeAll")
                {
                    message = message.Replace(commandParts[1], commandParts[2]);
                    Console.WriteLine(message);
                }
                else if (operation == "Reverse")
                {                    
                    var v = commandParts[1];
                    
                    if (!message.Contains(v))
                    {
                        Console.WriteLine("error");                        
                    }
                    else
                    {
                        message = message.Replace(v, ""); // cut it out

                        char[] arr = v.ToCharArray();   // reverse v
                        Array.Reverse(arr);             // reverse v
                        v = new string(arr);

                        message += v;


                        Console.WriteLine(message);
                    }                    
                }
                else if (operation == "InsertSpace")   // InsertSpace:|:5
                {
                    int index = int.Parse(commandParts[1]);
                    string modified = message.Insert(index, " ");
                    message = modified;
                    Console.WriteLine(message);
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");

        }
    }
}