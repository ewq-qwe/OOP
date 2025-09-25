using System;
class Program
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)('a' + i);
        }
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            int index = letter - 'a';
            Console.WriteLine($"{letter} -> {index}");
        }
    }
}
