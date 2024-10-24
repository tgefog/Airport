using System;

namespace Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            while (pens < 1 || pens > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                pens = int.Parse(Console.ReadLine());
            }
            int markers = int.Parse(Console.ReadLine());
            while (markers < 1 || markers > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                markers = int.Parse(Console.ReadLine());
            }
            int cleaningMaterials = int.Parse(Console.ReadLine());
            while (cleaningMaterials < 1 || cleaningMaterials > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                cleaningMaterials = int.Parse(Console.ReadLine());
            }
            int discountPercent = int.Parse(Console.ReadLine());
            while (discountPercent < 1 || discountPercent > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                discountPercent = int.Parse(Console.ReadLine());
            }
            double penSum = pens * 5.80;
            double markerSum = markers * 7.20;
            double cleaningMaterialsSum = cleaningMaterials * 1.20;
            double sum = penSum + markerSum + cleaningMaterialsSum;
            double discountedSum = sum - sum * discountPercent / 100;
            Console.WriteLine(discountedSum);
        }
    }
}