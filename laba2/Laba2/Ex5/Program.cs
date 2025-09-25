using System;
class Program
{
    static void Main()
    {
        char[] arr1 = Console.ReadLine().Replace(" ", "").ToCharArray();
        char[] arr2 = Console.ReadLine().Replace(" ", "").ToCharArray();
        int min = Math.Min(arr1.Length, arr2.Length);
        string result = "", first="", second="";
        for (int i = 0; i < min; i++)
        {
            if (arr1[i] > arr2[i])
            {
                first = new string(arr2);
                second = new string(arr1);
                break;
            }
            else if (arr1[i] < arr2[i])
            {
                first = new string(arr1);
                second = new string(arr2);
                break;
            }
        }
                Console.WriteLine(first);
                Console.WriteLine(second);
    }
}