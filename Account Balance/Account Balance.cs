using System;
namespace Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double accountMoney = 0;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                if (double.Parse(input) > 0)
                {
                    accountMoney += double.Parse(input);
                    Console.WriteLine($"Increase: {double.Parse(input):f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {accountMoney:f2}");
        }
    }
}