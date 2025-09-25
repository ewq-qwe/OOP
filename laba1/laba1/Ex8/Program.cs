using System;

class  Num
{
  static void Main()
    {
        int number, n, ndigit;
        number = int.Parse(Console.ReadLine());
        n= int.Parse(Console.ReadLine());
        if (number<Math.Pow(10,n-1))
        {
            Console.WriteLine("-");
        }
        else 
        {
            ndigit = (number / (int)Math.Pow(10, n - 1)) % 10;
            Console.WriteLine(ndigit);
        }
            
    }
}