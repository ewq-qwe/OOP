using System;
class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string Email { get; set; } = "n/a";
    public int Age { get; set; } = -1;
    public Employee(string name, decimal salary, string position, string department)
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
        Email = "n/a";
        Age = -1;
    }
    public Employee(string name, decimal salary, string position, string department, string email) : this(name, salary, position, department)
    {
        Email = email;
    }
    public Employee(string name, decimal salary, string position, string department, int age) : this(name, salary, position, department)
    {
        Age = age;
    }
    public Employee(string name, decimal salary, string position, string department, string email, int age) : this(name, salary, position, department)
    {
        Email = email;
        Age = age;
    }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();
        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            string name = tokens[0];
            decimal salary = decimal.Parse(tokens[1]);
            string position = tokens[2];
            string department = tokens[3];
            if (tokens.Length == 4)
            {
                employees.Add(new Employee(name, salary, position, department));
            }
            else if (tokens.Length == 5)
            {
                if (int.TryParse(tokens[4], out int age))
                {
                    employees.Add(new Employee(name, salary, position, department, age));
                }
                else
                {
                    string email = tokens[4];
                    employees.Add(new Employee(name, salary, position, department, email));
                }
            }
            else if (tokens.Length == 6)
            {
                string email = tokens[4];
                int age = int.Parse(tokens[5]);
                employees.Add(new Employee(name, salary, position, department, email, age));
            }
        }
        var bestDepartment = employees
            .GroupBy(e => e.Department)
            .OrderByDescending(g => g.Average(e => e.Salary))
            .First();
        Console.WriteLine($"Highest Average Salary: {bestDepartment.Key}");
        foreach(var emp in bestDepartment.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}");
        }
    }
}
