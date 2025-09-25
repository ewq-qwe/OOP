using System;

class Num
{
    static void Main()
    {
        int a, b, c;
        double average;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        average = (a + b + c) / 3.0;
        Console.WriteLine(average);
    }
}
