using System;

class Num
{
    static void Main()
    {
        double a, b, h;
        double area;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
        area = (a + b) / 2.0 * h;
        Console.WriteLine(area);
    }
}