using System;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            while (chickenMenus < 0 || chickenMenus > 99)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                chickenMenus = int.Parse(Console.ReadLine());
            }
            int fishMenus = int.Parse(Console.ReadLine());
            while (fishMenus < 0 || fishMenus > 99)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                fishMenus = int.Parse(Console.ReadLine());
            }
            int vegetarianMenus = int.Parse(Console.ReadLine());
            while (vegetarianMenus < 0 || vegetarianMenus > 99)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                vegetarianMenus = int.Parse(Console.ReadLine());
            }
            double chickenCost = chickenMenus * 10.35;
            double fishCost = fishMenus * 12.40;
            double vegetarianCost = vegetarianMenus * 8.15;
            double menuCost = chickenCost + fishCost + vegetarianCost;
            double desertCost = menuCost * 0.2;
            double deliveryCost = 2.5;
            double totalCost = menuCost + desertCost + deliveryCost;
            Console.WriteLine(totalCost);
        }
    }
}