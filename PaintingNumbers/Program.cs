namespace PaintingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command.StartsWith("Change"))
                {
                    List<string> splitted = command.Split(" ").ToList();
                    int value = int.Parse(splitted[1]);
                    int replacement = int.Parse(splitted[2]);

                    int index = numbers.IndexOf(value);
                    if (index != -1)
                    {
                        numbers[index] = replacement;
                    }
                }

                if (command.StartsWith("Switch"))
                {
                    List<string> splitted = command.Split(" ").ToList();
                    int value1 = int.Parse(splitted[1]);
                    int value2 = int.Parse(splitted[2]);

                    if (numbers.Contains(value1) && numbers.Contains(value2))
                    {
                        int index1 = numbers.IndexOf(value1);
                        int index2 = numbers.IndexOf(value2);
                        numbers[index1] = value2;
                        numbers[index2] = value1;
                    }
                }

                if (command.StartsWith("Hide"))
                {
                    var parts = command.Split();
                    int numberToHide = int.Parse(parts[1]);
                    numbers.Remove(numberToHide);
                }

                if (command.StartsWith("Reverse"))
                {
                    numbers.Reverse();
                }

                if (command.StartsWith("Insert"))  // Insert 5 114
                {
                    List<string> splitted = command.Split(" ").ToList();

                    string placeStr = splitted[1];
                    string numStr = splitted[2];

                    int place = int.Parse(placeStr) +1;
                    int num = int.Parse(numStr);

                    bool indexExist = numbers.Count() > place;

                    if (indexExist)
                    {
                        numbers.Insert(place , num);
                    }
                    
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}