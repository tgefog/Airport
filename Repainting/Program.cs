using System;
namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylonSquareMeters = int.Parse(Console.ReadLine());
            while (naylonSquareMeters < 1 || naylonSquareMeters > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                naylonSquareMeters = int.Parse(Console.ReadLine());
            }
            int litresPaint = int.Parse(Console.ReadLine());
            while (litresPaint < 1 || litresPaint > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                litresPaint = int.Parse(Console.ReadLine());
            }
            int litresThinner = int.Parse(Console.ReadLine());
            while (litresThinner < 1 || litresThinner > 30)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                litresThinner = int.Parse(Console.ReadLine());
            }
            int workHours = int.Parse(Console.ReadLine());
            while (workHours < 1 || workHours > 9)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                workHours = int.Parse(Console.ReadLine());
            }
            double naylonCost = (naylonSquareMeters + 2) * 1.50;
            double paintCost = (litresPaint + litresPaint*0.10) * 14.50;
            double thinnerCost = litresThinner * 5;
            double bagCost = 0.4;
            double materialsCost = naylonCost + paintCost + thinnerCost + bagCost;
            double workersPay = (materialsCost * 0.3) * workHours;
            double finalSum = materialsCost + workersPay;
            Console.WriteLine(finalSum);
        }
    }
}