using System;
namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalCoins = 0;
            while (input != "Start")
            {
                if (double.Parse(input) == 0.1
                 || double.Parse(input) == 0.2
                 || double.Parse(input) == 0.5
                 || double.Parse(input) == 1
                 || double.Parse(input) == 2)
                {
                    totalCoins += double.Parse(input);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {double.Parse(input)}");
                }
                input = Console.ReadLine();
            }
            input= Console.ReadLine();
            while (input != "End")
            {
                if (input == "Nuts")
                {
                    if (totalCoins >= 2.0)
                    {
                        Console.WriteLine($"Purchased nuts");
                        totalCoins -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (totalCoins >= 0.7)
                    {
                        Console.WriteLine($"Purchased water");
                        totalCoins -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    if (totalCoins >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        totalCoins -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (totalCoins >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        totalCoins -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (totalCoins >= 1)
                    {
                        Console.WriteLine($"Purchased coke");
                        totalCoins -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                input= Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}