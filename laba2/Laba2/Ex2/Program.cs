using System;
class Program
{
    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int num = int.Parse(Console.ReadLine());
        int n=a.Length;
        int[] sum=new int[n];
        for(int r=0;r<num;r++)
        {
            int last = a[n - 1];
            for(int i=n-1;i>0;i--)
            {
                a[i]=a[i-1];
            }
            a[0]=last;
            for(int i=0;i<n;i++)
            {
                sum[i]+=a[i];
            }
        }
    
        Console.WriteLine(string.Join(" ",a));
        Console.WriteLine(string.Join(" ",sum));

    }


}