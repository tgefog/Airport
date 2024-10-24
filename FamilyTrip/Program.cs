using System;
namespace FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percentBonusExpenses = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                pricePerNight -= pricePerNight * 0.05;
            }
            double totalNightsPrice = nights * pricePerNight;
            double bonusExpenses = Budget * percentBonusExpenses / 100;
            if (Budget >= totalNightsPrice + bonusExpenses)
            {
                Console.WriteLine($"Ivanovi will be left with {Budget - (totalNightsPrice + bonusExpenses):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalNightsPrice + bonusExpenses - Budget:f2} leva needed.");
            }
        }
    }
}