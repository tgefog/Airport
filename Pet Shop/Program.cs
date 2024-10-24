using System;

namespace Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            while (dogFood < 0 || dogFood > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                dogFood = int.Parse(Console.ReadLine());
            }
            int catFood = int.Parse(Console.ReadLine());
            while (catFood < 0 || catFood > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                catFood = int.Parse(Console.ReadLine());
            }
            double dogFoodCost = dogFood * 2.5;
            double catFoodCost = catFood * 4;
            double totalCost = dogFoodCost + catFoodCost;
            Console.WriteLine(totalCost +" lv.");
        }
    }
}