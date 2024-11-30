namespace P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Town> towns = new List<Town>();

            while (command != "End")  // read input
            {
                if (command.Contains("||"))  // create town
                {
                    string[] data = command.Split("||");   // Tortuga||345000||1250
                    Town town = new Town();
                    town.Name = data[0];
                    town.Population = int.Parse(data[1]);
                    town.Gold = int.Parse(data[2]);

                    var sameTown = towns.FirstOrDefault(x => x.Name == town.Name);
                    if (sameTown == null)
                    {
                        towns.Add(town);
                    }
                    else
                    {
                        sameTown.Population += town.Population;
                        sameTown.Gold += town.Gold;
                    }
                }

                if (command.Contains("Sail"))
                {
                    break;
                }

                command = Console.ReadLine();
            }

            string line = Console.ReadLine();

            while (line != "End")
            {
                List<string> action = line.Split("=>").ToList();  // Plunder=>Tortuga=>75000=>380
                string actionType = action[0];
                string townName = action[1];

                if (actionType == "Plunder")
                {
                    var town = towns.FirstOrDefault(x => x.Name == townName);
                    int toKill = int.Parse(action[2]);
                    int goldToCapture = int.Parse(action[3]);

                    town.Population -= toKill;
                    town.Gold -= goldToCapture;

                    Console.WriteLine($"{town.Name} plundered! {goldToCapture} gold stolen, {toKill} citizens killed.");

                    if (town.Population <= 0 || town.Gold <= 0)
                    {
                        towns.Remove(town);
                        Console.WriteLine($"{town.Name} has been wiped off the map!");
                    }
                }
                else if (actionType == "Prosper")
                {
                    var town = towns.FirstOrDefault(x => x.Name == townName);
                    int goldToAdd = int.Parse(action[2]);

                    if (goldToAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        town.Gold += goldToAdd;
                        Console.WriteLine($"{goldToAdd} gold added to the city treasury. {town.Name} now has {town.Gold} gold.");
                    }
                }

                line = Console.ReadLine();
            }

            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");

                foreach (var town in towns)
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }

    public class Town
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
