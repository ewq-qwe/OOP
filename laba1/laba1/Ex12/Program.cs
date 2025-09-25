using System;
using System.Globalization;
class Num
{
    static void Main()
    {
        double a, b, c;
        a= double.Parse(Console.ReadLine());
        b= double.Parse(Console.ReadLine());
        c= double.Parse(Console.ReadLine());

        int negativenum=0;
        if(a<0) negativenum++;
        if(b<0) negativenum++;
        if(c<0) negativenum++;
        
        if (negativenum%2==0)
            Console.WriteLine("Positive");
        else
            Console.WriteLine("Negative");
    }
}