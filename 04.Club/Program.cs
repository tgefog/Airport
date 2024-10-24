using System;
namespace _04.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double targetSum = double.Parse(Console.ReadLine());
            double currentSum = 0;
            string coctailName;
            while ((coctailName = Console.ReadLine()) != "Party!")
            {
                int cocktailCount = int.Parse(Console.ReadLine());
                double cocktailPrice = coctailName.Length * cocktailCount;
                if (cocktailPrice % 2 != 0)
                {
                    cocktailPrice -= cocktailPrice * 0.25;
                }
                currentSum += cocktailPrice;
                if (currentSum >= targetSum)
                {
                    break;
                }
            }
            //Two possible outcomes
            //1. We have received Party and target is not reached
            if (currentSum >= targetSum)
            {
                Console.WriteLine("Target acquired.");
            }
            else
            {
                double moneyNeeded = targetSum - currentSum;
                Console.WriteLine($"We need {moneyNeeded:f2} leva more.");
            }
            Console.WriteLine($"Club income - {currentSum:f2} leva.");
            //2.We have reached the target and break the loop
        }
    }
}