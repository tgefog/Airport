using System;

namespace YardGreetings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            while (squareMeters < 0.0 || squareMeters > 10000.0)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                squareMeters = double.Parse(Console.ReadLine());
            }
            double cost = squareMeters * 7.61;
            double discount = cost * 0.18;
            double finalCost = cost - discount;
            Console.WriteLine("The final price is " + finalCost + " lv.");
            Console.WriteLine("The discount is " + discount + " lv.");
        }
    }
}