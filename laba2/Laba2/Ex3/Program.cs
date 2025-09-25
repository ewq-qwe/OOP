using System;
class Program
{
    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int lenght = a.Length/4;
        int[] first=new int[lenght*2];
        int[] last=new int[lenght*2];
        int[] sum=new int[lenght*2];
        for (int i=0;i<lenght;i++)
        {
            first[i] = a[lenght - 1 - i];
        }
        for(int i=0;i<lenght;i++)
        {
            first[lenght+i] = a[a.Length-1-i];
        }
        for(int i=0;i<lenght*2;i++)
        {
            last[i]=a[lenght+i];
        }
        for (int i=0;i<lenght*2;i++)
        {
            sum[i]=first[i]+last[i];
        }
        Console.WriteLine(string.Join(" ", sum));
    }
}