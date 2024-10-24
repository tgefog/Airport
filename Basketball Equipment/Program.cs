using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyTrainingTax = int.Parse(Console.ReadLine());
            while (yearlyTrainingTax < 0 || yearlyTrainingTax > 9999)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                yearlyTrainingTax = int.Parse(Console.ReadLine());
            }
            double shoesCost = yearlyTrainingTax - yearlyTrainingTax * 0.4;
            double clothingCost = shoesCost - shoesCost * 0.2;
            double ballCost = clothingCost * 0.25;
            double accessoryCost = ballCost * 0.2;
            double totalCost = yearlyTrainingTax + shoesCost + clothingCost + ballCost + accessoryCost;
            Console.WriteLine(totalCost);
        }
    }
}