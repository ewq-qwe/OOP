using System;
class Progam
{
    static void Main()
    {
        string[] a = Console.ReadLine().Split(' ');
        string[] b = Console.ReadLine().Split(' ');
        int num = int.Parse(Console.ReadLine());

        int left = 0;
        for(int i=0;i<num;i++)
        {
            if (a[i] == b[i])
            {
                left++;
            }
            else
            {
                break;
            }
        }
        int right = 0;
        for (int i=0;i<num;i++)
        {
            if (a[a.Length-1-i] == b[b.Length - 1 - i])
            {
                right++;
            }
            else
            {
                break;
            }
        }
        if(left==0&&right==0)
        {
            Console.WriteLine("-");
        }
        if(left>=right)
        {
            Console.WriteLine($"{string.Join(" ",a[..left])}");
        }
        else
        {
            Console.WriteLine($"{string.Join(" ", a[^right..])}");
        }
    }
}