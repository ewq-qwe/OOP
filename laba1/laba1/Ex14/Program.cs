using System;
class Num
{
    static void Main()
    {
        int factorial=1, n;
        n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}
