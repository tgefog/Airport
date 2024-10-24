﻿namespace _07._Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[], Predicate<string>> print = (names, match) =>
            {
                foreach (var name in names)
                {
                    if (match(name))
                    {
                        Console.WriteLine(name);
                    }
                }
            };
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(names, n => n.Length <= length);
        }
    }
}