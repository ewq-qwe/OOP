using System;
class Engine
{
    public string Model { get; set; }
    public int Power { get; set; }
    public string Displacement { get; set; }
    public string Efficiency { get; set; }
    public Engine(string model, int power, string displacement = "n/a", string efficiency = "n/a")
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency;
    }
}
class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public string Weight { get; set; } 
    public string Color { get; set; }
    public Car(string model, Engine engine, string weight = "n/a", string color = "n/a")
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color;
    }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
        for(int i=0;i<n;i++)
        {
            string[] tokens = Console.ReadLine().Split();
            string model = tokens[0];
            int power = int.Parse(tokens[1]);
            string displacement = "n/a";
            string efficiency = "n/a";
            if (tokens.Length >= 3)
                displacement = tokens[2];
            if (tokens.Length == 4)
                efficiency = tokens[3];
            engines[model] = new Engine(model, power, displacement, efficiency);

        }
        int m = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for(int i=0;i<m;i++)
        {
            string[] tokens = Console.ReadLine().Split();
            string model = tokens[0];
            Engine engine = engines[tokens[1]];
            string weight = "n/a";
            string color = "n/a";

            if (tokens.Length >= 3)
                weight = tokens[2];
            if (tokens.Length == 4)
                color = tokens[3];

            cars.Add(new Car(model, engine, weight, color));

        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"{car.Engine.Model}:");
            Console.WriteLine($"Power: {car.Engine.Power}");
            Console.WriteLine($"Displacement: {car.Engine.Displacement}");
            Console.WriteLine($"Efficiency: {car.Engine.Efficiency}");
            Console.WriteLine($"Weight: {car.Weight}");
            Console.WriteLine($"Color: {car.Color}");

        }
    }
}