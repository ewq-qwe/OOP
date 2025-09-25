using System;
class Num  
{
    static void Main()  
    {  
        int n, lastDigit;
        n= int.Parse(Console.ReadLine());
        lastDigit = n % 10;
        Console.WriteLine(lastDigit);
    }
}
