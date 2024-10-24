using System;
namespace Cake
{
    internal class Cake
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cake = cakeLenght * cakeWidth;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "STOP")
            {
                if (int.Parse(input) <= cake)
                {
                    cake -= int.Parse(input);
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake - int.Parse(input))} pieces more.");
                    break;
                }
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{cake} pieces are left.");
            }

        }
    }
}