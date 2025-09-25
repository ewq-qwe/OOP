using System;
class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelPerKm { get; set; }
    public int DistanceTraveled { get; set; }

    public Car(string model, double fuelAmount, double fuelPerKm)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelPerKm = fuelPerKm;
        DistanceTraveled = 0;
    }
    public bool Drive(int distance)
    {
        double neededFuel = distance * FuelPerKm;
        if (neededFuel <= FuelAmount)
        {
            FuelAmount -= neededFuel;
            DistanceTraveled += distance;
            return true;
        }
        else
        {
            Console.WriteLine("Недостатньо палива для руху");
            return false;
        }
    }
}
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelPerKm = double.Parse(tokens[2]);
                cars[model] = new Car(model, fuelAmount, fuelPerKm);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] parts = command.Split();
                if (parts[0] == "Drive")
                {
                    string model = parts[1];
                    int km = int.Parse(parts[2]);
                    cars[model].Drive(km);
                }
            }
            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
