namespace ActivationKey2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();  // asdfghj

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                List<string> parts = new List<string>(command.Split(">>>"));
                string action = parts[0];

                if (action == "Slice")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);

                    string sliced = "";

                    for (int i = 0; i < key.Length; i++)
                    {
                        if (!(i >= startIndex && i < endIndex))
                        {
                            sliced += key[i];
                        }                        
                    }

                    key = sliced;

                    Console.WriteLine(key);

                }
                else if (action == "Flip")
                {
                    string model = parts[1];

                    int startIndex = int.Parse(parts[2]);
                    int endIndex = int.Parse(parts[3]);

                    string temporal = "";

                    if (model == "Upper")
                    {
                        for (int i = 0; i < key.Length; i++)
                        {
                            if (!(i >= startIndex && i < endIndex))
                            {
                                temporal += key[i];
                            }
                            else
                            {                                
                                temporal += key[i].ToString().ToUpper();
                            }
                        }
                    }
                    else if (model == "Lower")
                    {
                        for (int i = 0; i < key.Length; i++)
                        {
                            if (!(i >= startIndex && i < endIndex))
                            {
                                temporal += key[i];
                            }
                            else
                            {
                                temporal += key[i].ToString().ToLower();
                            }
                        }
                        
                    }

                    key = temporal;

                    Console.WriteLine(key);

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


                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}