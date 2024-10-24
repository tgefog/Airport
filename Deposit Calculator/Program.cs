using System;

namespace Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            while (depositedSum < 100.0 || depositedSum > 10000.0)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                depositedSum = double.Parse(Console.ReadLine());
            }
            int deadline = int.Parse(Console.ReadLine());
            while (deadline < 1 || deadline > 12)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                deadline = int.Parse(Console.ReadLine());
            }
            double yearlyInterestPercent = double.Parse(Console.ReadLine());
            while (yearlyInterestPercent < 0.0 || yearlyInterestPercent > 100.0)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                yearlyInterestPercent = double.Parse(Console.ReadLine());
            }
            double interest = depositedSum * (yearlyInterestPercent / 100);
            double monthlyInterest = interest / 12;
            double totalSum = depositedSum + deadline * monthlyInterest;
            Console.WriteLine(totalSum);
        }
    }
}