namespace GeneratingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "find even")
                {
                    List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
                    Print(evenNumbers);
                }

                if (command == "find odd")
                {
                    List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
                    Print(oddNumbers);
                }

                if (command.StartsWith("remove greater than"))
                {
                    List<string> splitted = command.Split(" ").ToList();
                    int digit = int.Parse(splitted.Last());
                    numbers.RemoveAll(x => x > digit);
                    
                }

                if (command.StartsWith("add to start"))
                {
                    List<string> splitted = command.Split(" ").ToList();
                    splitted.RemoveAt(0);
                    splitted.RemoveAt(0);
                    splitted.RemoveAt(0);

                    List<int> toAdd = splitted.Select(int.Parse).ToList();
                    numbers.InsertRange(0, toAdd);

                }

                if (command.StartsWith("replace"))
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

                if (command.StartsWith("remove at index"))
                {
                    List<string> splitted = command.Split(" ").ToList();
                    int index = int.Parse(splitted[3]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                }

                command = Console.ReadLine();
            }

            PrintWithComma(numbers);
        }



        static void Print(List<int> numbers)
        {
            var forPrint = string.Join(" ", numbers);

            Console.WriteLine(forPrint);
        }

        static void PrintWithComma(List<int> numbers)
        {
            var forPrint = string.Join(", ", numbers);

            Console.WriteLine(forPrint);
        }
    }
}