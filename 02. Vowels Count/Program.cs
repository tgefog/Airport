﻿namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int vowelsCount = GetVowelsCount(sentence);
            Console.WriteLine(vowelsCount);
        }
        static int GetVowelsCount(string sentence)
        {
            int count = 0;
            sentence = sentence.ToLower();
            foreach (var symbol in sentence)
            {
                if (symbol == 'e' ||
                    symbol == 'o' ||
                    symbol == 'a' ||
                    symbol == 'i' ||
                    symbol == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}