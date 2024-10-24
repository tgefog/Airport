﻿namespace Lists._03.House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < guestsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string name = arguments[0];
                if (arguments[2] == "going!")
                {
                    AddGuest(guestList, name);
                }
                else if (arguments[2] == "not")
                {
                    RemoveGuest(guestList, name);
                }
            }
            Console.WriteLine(string.Join("\n", guestList));
        }
        private static void AddGuest(List<string> guestList, string name)
        {
            if (!guestList.Contains(name))
            {
                guestList.Add(name);
            }
            else
            {
                Console.WriteLine($"{name} is already in the list!");
            }
        }

        private static void RemoveGuest(List<string> guestList, string name)
        {
            if (!guestList.Contains(name))
            {
                Console.WriteLine($"{name} is not in the list!");
            }
            else
            {
                guestList.Remove(name);
            }
        }
    }
}