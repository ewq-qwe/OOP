using System;
class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int start=0, len=1;
        int bestStart = 0;
        int bestLen = 1;
        for(int i=1;i<arr.Length;i++)
        {
            if (arr[i] == arr[i-1])
            {
                len++;
            }
            else
            {
                start = i;
                len = 1;
            }
            if(len>bestLen)
            {
                bestLen = len;
                bestStart = start;
            }
         
        }
        for(int i=bestStart;i<bestStart+bestLen;i++)
            {
                Console.Write(arr[i]+" ");
            }
    }
}