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
                    var k = commandParts[1];

                    if (!message.Contains(k))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        message = message.Replace(k, ""); 

                        char[] arr = k.ToCharArray();   
                        Array.Reverse(arr);             
                        k = new string(arr);

                        message += k;


                        Console.WriteLine(message);
                    }
                }
                else if (operation == "InsertSpace")   
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