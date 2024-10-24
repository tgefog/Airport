﻿namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }
            int evenNumber = numbers.Single(nc => nc.Value % 2 == 0).Key;
            Console.WriteLine(evenNumber);
        }
    }
}