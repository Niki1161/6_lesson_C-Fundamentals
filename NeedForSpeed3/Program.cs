namespace NeedForSpeed3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberCars; i++)
            {
                string[] data = Console.ReadLine().Split("|");    // Audi A6|38000|62

                Car car = new Car();
                car.Name = data[0];
                car.Mileage = int.Parse(data[1]);
                car.Fuel = int.Parse(data[2]);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                if (command.Contains("Drive"))   // Drive : Audi A6 : 543 : 47
                {
                    List<string> splitted = command.Split(":").Select(x => x.Trim()).ToList();

                    var car = cars.First(c => c.Name == splitted[1]);

                    int consumption = int.Parse(splitted[3]);

                    int kilometers = int.Parse(splitted[2]);
                    if (car.Fuel >= consumption) // if true, its enough
                    {
                        car.Fuel = car.Fuel - consumption;
                        car.Mileage += kilometers;

                        Console.WriteLine($"{car.Name} driven for {kilometers} kilometers. {consumption} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }

                    if (car.Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {car.Name}!");
                        cars.Remove(car);
                    }
                }

                if (command.Contains("Refuel"))   // Refuel : Audi A6 : 50
                {
                    List<string> splitted = command.Split(":").Select(x => x.Trim()).ToList();

                    var car = cars.First(c => c.Name == splitted[1]);

                    int reffil = int.Parse(splitted[2]);

                    car.Fuel += reffil;

                    if (car.Fuel > 75)
                    {
                        car.Fuel = 75;
                    }

                    Console.WriteLine($"{car.Name} refueled with {reffil} liters");
                }

                if (command.Contains("Revert"))
                {
                    List<string> splitted = command.Split(":").Select(x => x.Trim()).ToList();

                    int revert = int.Parse(splitted[2]);

                    var car = cars.First(c => c.Name == splitted[1]);

                    car.Mileage -= revert;


                    if (car.Mileage < 10000)
                    {
                        car.Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car.Name} mileage decreased by {revert} kilometers");

                    }

                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }


        }
    }

    public class Car
    {
        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}