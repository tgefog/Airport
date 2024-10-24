using System;
namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int currentYield = startingYield;
            int currentSpices = 0;
            int days = 0;
            while (currentYield >= 100)
            {
                currentSpices += currentYield - 26;
                currentYield -= 10;
                days++;
            }
            currentSpices -= 26;
            Console.WriteLine(days);
            Console.WriteLine(currentSpices);
        }
    }
}