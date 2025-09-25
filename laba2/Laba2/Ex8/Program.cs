using System;
class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] freq = new int[65536];
        for(int i=0;i< arr.Length; i++)
        {
            freq[arr[i]]++;
        }
        int most = 0;
        for(int i=0;i<arr.Length;i++)
        {
            if (freq[arr[i]] > freq[most])
            {
                most = arr[i];
            }
        }
        int maxfreq = 0;
        for(int i=0;i<freq.Length;i++)
        {
            if(freq[i]>maxfreq)
            {
                maxfreq = freq[i];
            }
        }
        Console.WriteLine($"Число {most} зустрічається частіше за все ({maxfreq} разів)");
    }
}