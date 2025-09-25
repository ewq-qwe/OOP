using System;
class Num
{
    static void Main()
    {
        int n;
        n = int.Parse(Console.ReadLine());
        bool result = (n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0);
            Console.WriteLine(result);
    }
}