using System;
class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int difference = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) == difference)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}