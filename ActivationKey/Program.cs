namespace ActivationKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                List<string> parts = new List<string>(command.Split(">>>"));

                string action = parts[0];

                if (action == "Slice")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);

                    string temporal = "";

                    for (int i = 0; i < key.Length; i++)
                    {
                        if (i >= startIndex && i < endIndex)
                        {
                        }
                        else
                        {
                            temporal += key[i];
                        }
                    }

                    key = temporal;

                    Console.WriteLine(key);
                }
                else if (action == "Flip")
                {
                    string caseType = parts[1];
                    int startIndex = int.Parse(parts[2]);
                    int endIndex = int.Parse(parts[3]);

                    string firstPart = key.Substring(0, startIndex);
                    string middlePart = key.Substring(startIndex, endIndex - startIndex);
                    string lastPart = key.Substring(endIndex);

                    if (caseType == "Upper")
                    {
                        middlePart = middlePart.ToUpper();
                    }
                    else if (caseType == "Lower")
                    {
                        middlePart = middlePart.ToLower();
                    }

                    key = firstPart + middlePart + lastPart;
                    Console.WriteLine(key); // Print the updated key
                }
                else if (action == "Contains")
                {
                    string substring = parts[1];

                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                command = Console.ReadLine(); // Read the next command
            }

            Console.WriteLine($"Your activation key is: {key}"); // Final output

            //var demo = new Demo();
            //var demo2 = new Demo();

            //var str = demo.ToString();
            //var equal = demo.Equals(demo2);
            //var type = demo.GetType();
        }


    }

    class Demo
    {
        public void Print()
        {

        }
        public int MyProperty { get; set; }
    }
}
