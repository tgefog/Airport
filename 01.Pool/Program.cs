using System;
namespace _01.Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entryTax = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double peopleTax = people * entryTax;
            int umbrellaCount = (int)(Math.Ceiling(people / 2.0));
            int sunbedCount = (int)(Math.Ceiling(people * 0.75));
            double totalPrice = peopleTax + umbrellaCount * umbrellaPrice + sunbedPrice * sunbedCount;

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}